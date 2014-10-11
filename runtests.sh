#!/bin/sh
rm -rf test-results/*.xml
mkdir -p test-results
xbuild
mono --runtime=v4.0.30319 packages/xunit.runners.1.9.2/tools/xunit.console.clr4.x86.exe bin/Debug/MonoXunit.Tests.dll /nunit test-results/nunit-results.xml
xsltproc .analysis/nunit-to-junit.xsl test-results/nunit-results.xml > test-results/junit-results.xml
xsltproc .analysis/junit-to-trx.xsl test-results/junit-results.xml > test-results/trx-results.trx
