Asset Service Application
----------------------------

The details of the image is given below:
REPOSITORY                                TAG       IMAGE ID       CREATED         SIZE
damilolaadegunwa/Assetservice-webapi   latest    781734b82673   20/09/2021      224MB

its containers:
CONTAINER ID   IMAGE                                     COMMAND                  CREATED              STATUS              PORTS                                   NAMES
b2697c16eefa   damilolaadegunwa/Assetservice-webapi   "dotnet AssetServ�"   About a minute ago   Up About a minute   0.0.0.0:8080->80/tcp, :::8080->80/tcp   first-Assetservice-webapi-container

docker build -t damilolaadegunwa/Assetservice-webapi .
docker run --name first-Assetservice-webapi-container -p 8080:80 damilolaadegunwa/Assetservice-webapi
docker start first-Assetservice-webapi-container
docker stop first-Assetservice-webapi-container
docker kill first-Assetservice-webapi-container

docker rm <container id or name>
docker rmi <image name or id>

docker --version

container created from k8s 
CONTAINER ID   IMAGE                                     COMMAND                  CREATED          STATUS          PORTS     NAMES
fc4595abee6d   damilolaadegunwa/Assetservice-webapi   "dotnet AssetServ�"   18 minutes ago   Up 18 minutes             k8s_Assetservice_Assets-depl-7f87b47f85-7fc4p_default_5ef5b732-2088-4bb7-b78b-af3234bfb292_0

kubernetes deployment

NAME             READY   UP-TO-DATE   AVAILABLE   AGE   CONTAINERS        IMAGES                                    SELECTOR
Assets-depl   1/1     1            1           13m   Assetservice   damilolaadegunwa/Assetservice-webapi   app=Assetservice

kubernetes services

NAME         TYPE        CLUSTER-IP   EXTERNAL-IP   PORT(S)   AGE     SELECTOR
kubernetes   ClusterIP   10.96.0.1    <none>        443/TCP   4h28m   <none>

kubernetes pod

NAME                              READY   STATUS    RESTARTS   AGE   IP         NODE             NOMINATED NODE   READINESS GATES
Assets-depl-7f87b47f85-7fc4p   1/1     Running   0          11m   10.1.0.6   docker-desktop   <none>           <none>

kubectl version
kubectl apply -f Assets-depl.yaml
kubectl get pod -o wide
kubectl get services -o wide
kubectl get deployment -o wide
kubectl delete deployment Assets-depl
kubectl rollout restart deployment Assets-depl
kubectl get namespace
kubectl get storageclass 

PS C:\Users\damil\source\repos\platfrom-command-microservice\AssetService> docker build -t damilolaadegunwa/assetservice-webapi .   
[+] Building 147.9s (14/14) FINISHED
 => [internal] load build definition from Dockerfile                                                                                                                                                                              0.0s 
 => => transferring dockerfile: 314B                                                                                                                                                                                              0.0s 
 => [internal] load .dockerignore                                                                                                                                                                                                 0.0s 
 => => transferring context: 53B                                                                                                                                                                                                  0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                                                              0.0s 
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                                                                                                                                 1.1s 
 => [internal] load build context                                                                                                                                                                                                 0.2s 
 => => transferring context: 402.96kB                                                                                                                                                                                             0.1s 
 => [build-env 1/5] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:c05f1855774c8472961952f0b3ae5da61f3f959da77ea5f3318e39e780ccd5f3                                                                                                 0.0s 
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                                                                        0.0s 
 => CACHED [build-env 2/5] WORKDIR /app                                                                                                                                                                                           0.0s 
 => [build-env 3/5] COPY *.csproj ./                                                                                                                                                                                              0.0s 
 => [build-env 4/5] COPY . ./                                                                                                                                                                                                     0.0s 
 => [build-env 5/5] RUN dotnet publish -c Release -o out                                                                                                                                                                        146.1s 
 => CACHED [stage-1 2/3] WORKDIR /app                                                                                                                                                                                             0.0s 
 => [stage-1 3/3] COPY --from=build-env /app/out .                                                                                                                                                                                0.1s 
 => exporting to image                                                                                                                                                                                                            0.2s 
 => => exporting layers                                                                                                                                                                                                           0.2s 
 => => writing image sha256:fbc323b62b6e4c271f8e97cfe1188a2f3f53e1774e8f796f7d13b4302272d918                                                                                                                                      0.0s 
 => => naming to docker.io/damilolaadegunwa/assetservice-webapi                                                                                                                                                                   0.0s 
PS C:\Users\damil\source\repos\platfrom-command-microservice\AssetService> 