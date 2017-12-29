mkdir -p ./Publish 

docker run --rm -it psythyst/psythyst-core-data:latest cat /Psythyst.Core.Data/Publish/Psythyst.Core.Data.dll > ./Publish/Psythyst.Core.Data.dll
docker run --rm -it psythyst/psythyst-core-data:latest cat /Psythyst.Core.Data/Publish/Psythyst.Core.Data.deps.json > ./Publish/Psythyst.Core.Data.deps.json
docker run --rm -it psythyst/psythyst-core-data:latest cat /Psythyst.Core.Data/Publish/Psythyst.Core.Data.pdb > ./Publish/Psythyst.Core.Data.pdb