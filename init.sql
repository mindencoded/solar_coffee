-- Start Psql command line tool.
-- - On Windows:  set "PGPASSWORD=postgres" && psql -h localhost -U postgres -d postgres
-- - On Linux: PGPASSWORD="postgres" psql -h localhost -U postgres -d postgres

-- CREATE ROLE
CREATE USER solar_dev WITH PASSWORD 'solar_dev';

-- CREATE DATABASE
CREATE DATABASE solar_dev_db;

-- connect to database as postgres
-- \c solar_dev_db;

-- GRANT
GRANT ALL PRIVILEGES ON DATABASE solar_dev_db TO solar_dev;

-- GRANT
GRANT ALL ON SCHEMA public TO solar_dev;
