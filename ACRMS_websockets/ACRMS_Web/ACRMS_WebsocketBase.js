var Nconn;
var Response = false;
var rowNumber = 1;
var count  = 0;

function openNativeWrapperConnection() {
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

function sendRequestNative(name, parameters) {
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
        var data = json.parameters.StartMonitoring;
        var tableDataFromProcesses = [];
        //table(json)
        for (var key in data) {
            tableDataFromProcesses.push([data[key][0],data[key][1],data[key][2]]);
        }
    table(tableDataFromProcesses);
    Response = true;
        if(count == 0){
            graph();
            count++;
            //console.log(json);
        }
    }

function table(data){
    var tableData = data;
    $('#tableContainer')
            .TidyTable({
                columnTitles : ['Process Name','Process ID','CPU Usage'],
                columnValues : tableData,
              postProcess : {
                    column : doSomething4
                }
            });
}

function doSomething4(col) {
    col.on('click', function(col) {
        console.log($(this).parent().index() + 1);
        rowNumber = $(this).parent().index() + 1;
    });
}

function getUsageData(){
    return document.getElementById("tableContainer").getElementsByTagName("*")[0].rows[rowNumber].cells[2].attributes[0].value;
}

function graph(){
    Highcharts.setOptions({
            global: {
                useUTC: false
            }
        });

        $('#container').highcharts({
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
                                y = parseInt(getUsageData());
                            series.addPoint([x, y], true, true);
                        }, 1000);
                    }
                }
            },
            title: {
                text: 'CPU Usage'
            },
            xAxis: {
                type: 'datetime',
                tickPixelInterval: 50
            },
            yAxis: {
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
                name: 'Random data',
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