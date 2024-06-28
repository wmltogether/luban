cd ../src
dotnet publish -f net8.0 -c Release -r osx-x64 -p:UseAppHost=true --sc true -p DebugType=embedded
