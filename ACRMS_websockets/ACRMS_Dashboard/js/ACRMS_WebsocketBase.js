var webSocketBase = (function () {
    var Nconn;
    var getCPUUsageResponse = false;
    var getRAMUsageResponse = false;
    var getDiskUsageResponse = false;
    var getCPUUsageCount  = 0;
    var getRAMUsageCount  = 0;
    var getDiskUsageCount  = 0;
    var cpuPercentage = 0;
    var ramPercentage = 0.0;
    var diskPercentage = 0.0;

    function _openNativeWrapperConnection() {
            // uses global 'conn' object
            Nconn = new WebSocket('ws://localhost:12001');

            Nconn.onopen = function () {
                console.log('Connected');
                return true;
            };

            Nconn.onmessage = function (event) {
                console.log('Data Received');
                var message = event.data;
                processResponse(message);
            };

            Nconn.onerror = function () {
                console.log('Error');
                return false;
            };

            Nconn.onclose = function () {
                console.log('Disconnected');
                return false;
            };
        }

    function _sendRequestNative(name, parameters) {
            var pid = 1;

            var JSONobj = {
                'request': name,
                'parameters': parameters,
                'pid': pid
            };
            var JSONString = JSON.stringify(JSONobj, null);
            Nconn.send(JSONString);
        }

    function processResponse(message) {
        //convert to JSON format
        var json = JSON.parse(message);
        if(json.response === 'getCPUUsage'){
            getCPUUsageResponseHandler(message);
        }else if(json.response === 'getRAMUsage'){
            getRAMUsageResponseHandler(message);
        }else if(json.response === 'getDISKUsage'){
            getDISKUsageResponseHandler(message);
        }
    }

    function startMonitoringResponseHandler(message){
        //convert to JSON format
        var json = JSON.parse(message);
        var data = json.parameters.StartMonitoring;
        var tableDataFromProcesses = [];
        //table(json)
        for (var key in data) {
            tableDataFromProcesses.push([data[key][0],data[key][1],data[key][2]]);
        }
        table(tableDataFromProcesses);
        startMonitoringResponse = true;
        if(startMonitoringCount == 0){
            startMonitoringgraph();
            startMonitoringCount++;
            //console.log(json);
        }
    }

    function getDISKUsageResponseHandler(message){
        //convert to JSON format
        var json = JSON.parse(message);
        diskPercentage = (json.parameters.GetDiskUsage.diskUsage.DiskTransB)/(1024*1024);
        getDiskUsageResponse = true;
        if(getDiskUsageCount == 0){
            diskUsagegraph();
            getDiskUsageCount++;
            //console.log(json);
        }
    }

    function getCPUUsageResponseHandler(message){
        //convert to JSON format
        var json = JSON.parse(message);
        cpuPercentage = json.parameters.GetCpuUsage.cpuUsage;
        getCPUUsageResponse = true;
        if(getCPUUsageCount == 0){
            cpuUsagegraph();
            getCPUUsageCount++;
            //console.log(json);
        }
    }

    function getRAMUsageResponseHandler(message){
        //convert to JSON format
        var json = JSON.parse(message);
        ramPercentage = json.parameters.GetRamUsage.ramUsage.dwMemoryLoad;
        getRAMUsageResponse = true;
        if(getRAMUsageCount == 0){
            ramUsagegraph();
            getRAMUsageCount++;
            //console.log(json);
        }
    }

    function cpuUsageData(){
        return cpuPercentage;
    }

    function ramUsageData(){
        return ramPercentage;
    }

    function diskUsageData(){
        return diskPercentage;
    }

    function cpuUsagegraph(){
        Highcharts.setOptions({
                global: {
                    useUTC: false
                }
            });

            $('#getCPUUsageGraph').highcharts({
                chart: {
                    type: 'spline',
                    animation: Highcharts.svg, // don't animate in old IE
                    marginRight: 10,
                    events: {
                        load: function () {

                            // set up the updating of the chart each second
                            var series = this.series[0];
                            setInterval(function () {
                                var x = (new Date()).getTime(), // current time
                                    y = parseInt(cpuUsageData());
                                series.addPoint([x, y], true, true);
                            }, 1000);
                        }
                    }
                },
                title: {
                    text: 'CPU Percentage'
                },
                xAxis: {
                    type: 'datetime',
                    tickPixelInterval: 50,
                    labels: {
                        enabled: false
                    }
                },
                yAxis: {
                    floor: 0,
                    ceiling: 100,
                    title: {
                        text: 'CPU %'
                    },
                    plotLines: [{
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }]
                },
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.series.name + '</b><br/>' +
                            Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) + '<br/>' +
                            Highcharts.numberFormat(this.y, 2);
                    }
                },
                legend: {
                    enabled: false
                },
                exporting: {
                    enabled: false
                },
                series: [{
                    name: 'CPU Usage',
                    data: (function () {
                        // generate an array of random data
                        var data = [],
                            time = (new Date()).getTime(),
                            i;

                        for (i = -19; i <= 0; i += 1) {
                            data.push({
                                x: time + i * 1000,
                                y: 0
                            });
                        }
                        return data;
                    }())
                }]
            });
    }

    function ramUsagegraph(){
        Highcharts.setOptions({
                global: {
                    useUTC: false
                }
            });

            $('#getRAMUsageGraph').highcharts({
                chart: {
                    type: 'spline',
                    animation: Highcharts.svg, // don't animate in old IE
                    marginRight: 10,
                    events: {
                        load: function () {

                            // set up the updating of the chart each second
                            var series = this.series[0];
                            setInterval(function () {
                                var x = (new Date()).getTime(), // current time
                                    y = parseFloat(ramUsageData());
                                series.addPoint([x, y], true, true);
                            }, 1000);
                        }
                    }
                },
                title: {
                    text: 'RAM Percentage'
                },
                xAxis: {
                    type: 'datetime',
                    tickPixelInterval: 50,
                    labels: {
                        enabled: false
                    }
                },
                yAxis: {
                    floor: 0,
                    ceiling: 100,
                    title: {
                        text: 'RAM %'
                    },
                    plotLines: [{
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }]
                },
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.series.name + '</b><br/>' +
                            Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) + '<br/>' +
                            Highcharts.numberFormat(this.y, 2);
                    }
                },
                legend: {
                    enabled: false
                },
                exporting: {
                    enabled: false
                },
                series: [{
                    name: 'RAM Usage',
                    data: (function () {
                        // generate an array of random data
                        var data = [],
                            time = (new Date()).getTime(),
                            i;

                        for (i = -19; i <= 0; i += 1) {
                            data.push({
                                x: time + i * 1000,
                                y: 0
                            });
                        }
                        return data;
                    }())
                }]
            });
    }

    function diskUsagegraph(){
        Highcharts.setOptions({
                global: {
                    useUTC: false
                }
            });

            $('#getDISKUsageGraph').highcharts({
                chart: {
                    type: 'spline',
                    animation: Highcharts.svg, // don't animate in old IE
                    marginRight: 10,
                    events: {
                        load: function () {

                            // set up the updating of the chart each second
                            var series = this.series[0];
                            setInterval(function () {
                                var x = (new Date()).getTime(), // current time
                                    y = parseFloat(diskUsageData());
                                series.addPoint([x, y], true, true);
                            }, 1000);
                        }
                    }
                },
                title: {
                    text: 'Disk Usage'
                },
                xAxis: {
                    type: 'datetime',
                    tickPixelInterval: 50,
                    labels: {
                        enabled: false
                    }
                },
                yAxis: {
                    floor: 0,
                    title: {
                        text: 'MB/s'
                    },
                    plotLines: [{
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }]
                },
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.series.name + '</b><br/>' +
                            Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', this.x) + '<br/>' +
                            Highcharts.numberFormat(this.y, 2);
                    }
                },
                legend: {
                    enabled: false
                },
                exporting: {
                    enabled: false
                },
                series: [{
                    name: 'Disk Usage',
                    data: (function () {
                        // generate an array of random data
                        var data = [],
                            time = (new Date()).getTime(),
                            i;

                        for (i = -19; i <= 0; i += 1) {
                            data.push({
                                x: time + i * 1000,
                                y: 0
                            });
                        }
                        return data;
                    }())
                }]
            });
    }

    function _getCPUUsageResponseValue(){
        return getCPUUsageResponse;
    }
    function _getRAMUsageResponseValue(){
        return getRAMUsageResponse;
    }
    function _getDISKUsageResponseValue(){
        return getDiskUsageResponse;
    }
    //Public methods which are exposed
    return {
        getDISKUsageResponseValue: _getDISKUsageResponseValue,
        getRAMUsageResponseValue: _getRAMUsageResponseValue,
        getCPUUsageResponseValue: _getCPUUsageResponseValue,
        openConnection: _openNativeWrapperConnection,
        sendRequestNative: _sendRequestNative
    };
}());