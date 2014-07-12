--
-- PostgreSQL database dump
--

-- Dumped from database version 9.3.4
-- Dumped by pg_dump version 9.3.4
-- Started on 2014-07-12 15:50:32

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 172 (class 3079 OID 11750)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 1949 (class 0 OID 0)
-- Dependencies: 172
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 171 (class 1259 OID 24648)
-- Name: malicious; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE malicious (
    id timestamp with time zone DEFAULT now() NOT NULL,
    filename text,
    report text
);


ALTER TABLE public.malicious OWNER TO postgres;

--
-- TOC entry 170 (class 1259 OID 24639)
-- Name: processes; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE processes (
    id timestamp with time zone DEFAULT now() NOT NULL,
    name text,
    duration text
);


ALTER TABLE public.processes OWNER TO postgres;

--
-- TOC entry 1941 (class 0 OID 24648)
-- Dependencies: 171
-- Data for Name: malicious; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY malicious (id, filename, report) FROM stdin;
\.


--
-- TOC entry 1940 (class 0 OID 24639)
-- Dependencies: 170
-- Data for Name: processes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY processes (id, name, duration) FROM stdin;
\.


--
-- TOC entry 1832 (class 2606 OID 24656)
-- Name: malicious_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY malicious
    ADD CONSTRAINT malicious_pkey PRIMARY KEY (id);


--
-- TOC entry 1830 (class 2606 OID 24646)
-- Name: processes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY processes
    ADD CONSTRAINT processes_pkey PRIMARY KEY (id);


--
-- TOC entry 1948 (class 0 OID 0)
-- Dependencies: 5
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2014-07-12 15:50:36

--
-- PostgreSQL database dump complete
--

