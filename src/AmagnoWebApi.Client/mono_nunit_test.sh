#!/usr/bin/env bash
#
# Generated by: https://github.com/openapitools/openapi-generator.git
#

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/AmagnoWebApi.Client.Test.dll"
rm src/AmagnoWebApi.Client.Test/bin/Debug/AmagnoWebApi.Client.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync
mono nuget.exe install src/AmagnoWebApi.Client.Test/packages.config -o packages

echo "[INFO] Install NUnit Console 3.x runners via NuGet"
mono nuget.exe install NUnit.ConsoleRunner -Version 3.10.0 -OutputDirectory packages

echo "[INFO] Build the solution and run the unit test"
xbuild AmagnoWebApi.Client.sln && \
    mono ./packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe src/AmagnoWebApi.Client.Test/bin/Debug/AmagnoWebApi.Client.Test.dll
