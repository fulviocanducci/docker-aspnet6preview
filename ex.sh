#!/bin/sh

sudo docker build -t source7 .
docker run -it --rm -p 5000:80 --name aspnetcore_sample source7