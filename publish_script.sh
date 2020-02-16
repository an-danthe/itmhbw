#!/bin/bash

p=$(pwd)

echo "publish..."
dotnet publish -c Release

echo "copy to docs"
from=$p'/bin/Release/netstandard2.1/publish/itmhbw/dist/*'
to=$p'/docs/'
cp -r $from $to

echo "replace some text"
#sed -i 's:href="/":href="/itmhbw/":g' $p'/docs/index.html'
cat docs/index_template.html > docs/index.html

echo "done"