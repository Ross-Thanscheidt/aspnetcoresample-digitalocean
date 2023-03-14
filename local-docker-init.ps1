docker rm -f digital-ocean-sample
docker rmi -f digital-ocean-aspnetcoresample
docker build --no-cache --progress=plain --tag=digital-ocean-aspnetcoresample .
docker run --name "digital-ocean-sample" -p 5001:80 -d digital-ocean-aspnetcoresample