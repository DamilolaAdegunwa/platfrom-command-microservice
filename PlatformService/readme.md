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

container created from k8s 
CONTAINER ID   IMAGE                                     COMMAND                  CREATED          STATUS          PORTS     NAMES
fc4595abee6d   damilolaadegunwa/platformservice-webapi   "dotnet PlatformServ…"   18 minutes ago   Up 18 minutes             k8s_platformservice_platforms-depl-7f87b47f85-7fc4p_default_5ef5b732-2088-4bb7-b78b-af3234bfb292_0

kubernetes deployment

NAME             READY   UP-TO-DATE   AVAILABLE   AGE   CONTAINERS        IMAGES                                    SELECTOR
platforms-depl   1/1     1            1           13m   platformservice   damilolaadegunwa/platformservice-webapi   app=platformservice

kubernetes services

NAME         TYPE        CLUSTER-IP   EXTERNAL-IP   PORT(S)   AGE     SELECTOR
kubernetes   ClusterIP   10.96.0.1    <none>        443/TCP   4h28m   <none>

kubernetes pod

NAME                              READY   STATUS    RESTARTS   AGE   IP         NODE             NOMINATED NODE   READINESS GATES
platforms-depl-7f87b47f85-7fc4p   1/1     Running   0          11m   10.1.0.6   docker-desktop   <none>           <none>

kubectl version
kubectl apply -f platforms-depl.yaml
kubectl get pod -o wide
kubectl get services -o wide
kubectl get deployment -o wide
kubectl delete deployment platforms-depl
kubectl rollout restart deployment platforms-depl
kubectl get namespace
kubectl get storageclass 

---------------------------------------------
PS C:\Users\damil\source\repos\platfrom-command-microservice\PlatformService> docker build -t damilolaadegunwa/platformservice-webapi .
[+] Building 195.0s (14/14) FINISHED
 => [internal] load build definition from Dockerfile                                                                                                                                          0.0s
 => => transferring dockerfile: 317B                                                                                                                                                          0.0s
 => [internal] load .dockerignore                                                                                                                                                             0.0s
 => => transferring context: 34B                                                                                                                                                              0.0s
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                          0.0s
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                                                                                             7.3s
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                                    0.0s
 => CACHED [stage-1 2/3] WORKDIR /app                                                                                                                                                         0.0s
 => [build-env 1/5] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:c05f1855774c8472961952f0b3ae5da61f3f959da77ea5f3318e39e780ccd5f3                                                             0.0s
 => CACHED [build-env 2/5] WORKDIR /app                                                                                                                                                       0.0s
 => [internal] load build context                                                                                                                                                             0.3s
 => => transferring context: 308.35kB                                                                                                                                                         0.1s
 => CACHED [build-env 3/5] COPY *.csproj ./                                                                                                                                                   0.0s
 => [build-env 4/5] COPY . ./                                                                                                                                                                 0.1s
 => [build-env 5/5] RUN dotnet publish -c Release -o out                                                                                                                                    187.2s
 => CACHED [stage-1 3/3] COPY --from=build-env /app/out .                                                                                                                                     0.0s
 => exporting to image                                                                                                                                                                        0.0s
 => => exporting layers                                                                                                                                                                       0.0s
 => => writing image sha256:e0151ba423afb6b7babc74b8d706678258ef9395471384f3bc9e22b42d11823c                                                                                                  0.0s
 => => naming to docker.io/damilolaadegunwa/platformservice-webapi