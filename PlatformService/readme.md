Platform Service Application
----------------------------

The details of the image is given below:
REPOSITORY                                TAG       IMAGE ID       CREATED         SIZE
damilolaadegunwa/platformservice-webapi   latest    781734b82673   20/09/2021      224MB

its containers:
CONTAINER ID   IMAGE                                     COMMAND                  CREATED              STATUS              PORTS                                   NAMES
b2697c16eefa   damilolaadegunwa/platformservice-webapi   "dotnet PlatformServ…"   About a minute ago   Up About a minute   0.0.0.0:8080->80/tcp, :::8080->80/tcp   first-platformservice-webapi-container

docker build -t damilolaadegunwa/platformservice-webapi .
docker run --name first-platformservice-webapi-container -p 8080:80 damilolaadegunwa/platformservice-webapi
docker start first-platformservice-webapi-container
docker stop first-platformservice-webapi-container
docker kill first-platformservice-webapi-container

docker rm <container id or name>
docker rmi <image name or id>

docker --version
