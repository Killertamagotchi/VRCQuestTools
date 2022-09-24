#!/bin/bash
set -eu

VERSION="${1}"
sed -i -b -e "s/\[Unreleased\]/\[${VERSION}\]/g" CHANGELOG*.md
sed -i -b -e "s/\"version\": \".*\"/\"version\": \"${VERSION}\"/g" package.json
sed -i -b -e "s/string Version = \".*\"/string Version = \"${VERSION}\"/g" Editor/VRCQuestTools.cs
git commit -am "Version ${VERSION}"
git tag "v${VERSION}"