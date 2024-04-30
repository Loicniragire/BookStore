#!/bin/bash

# Make sure to export the SA password as an environment variable
# before running this script.
# Example:
# export SA_PASSWORD=YourStrong!Passw0rd

# Check if the sqlserver container is already running
if [ $(docker ps -q -f name=sqlserver) ]; then
    echo "SQL Server container is already running."
else
    # Start the SQL Server container
	# TODO: exporting password as environment variable is not working...
    # docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=$SA_PASSWORD" \
	docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=1@PasswOrd' \
        -p 1433:1433 --name sqlserver \
		-v ~/sqlserver_container_data:/var/opt/mssql \
        -d mcr.microsoft.com/mssql/server:2019-latest 
    echo "SQL Server container started."
fi

