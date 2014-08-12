#!/bin/sh
rm -rf test-reports/results.xml
xbuild
mono packages/xunit.runners.1.9.2/tools/xunit.console.clr4.x86.exe bin/Debug/MonoXunit.Tests.dll /nunit testresults.xml

