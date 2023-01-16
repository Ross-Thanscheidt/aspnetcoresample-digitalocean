docker rm -f aspnetcoresample-digitalocean
docker rmi -f aspnetcoresample-digitalocean
docker build --no-cache --progress=plain --tag=aspnetcoresample-digitalocean .
docker run --name "aspnetcoresample-digitalocean" -p 80 -d aspnetcoresample-digitalocean