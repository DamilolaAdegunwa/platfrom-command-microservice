**********************************************************************
PS C:\Users\damil\source\repos\platfrom-command-microservice\LocationService> docker build -t damilolaadegunwa/locationservice-webapi .
[+] Building 246.4s (18/18) FINISHED
 => [internal] load build definition from Dockerfile                                                                                                                                          0.1s
 => => transferring dockerfile: 709B                                                                                                                                                          0.0s
 => [internal] load .dockerignore                                                                                                                                                             0.0s
 => => transferring context: 382B                                                                                                                                                             0.0s
 => [internal] load metadata for mcr.microsoft.com/dotnet/sdk:5.0                                                                                                                             6.6s
 => [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                          0.0s
 => [stage-1 1/3] FROM mcr.microsoft.com/dotnet/aspnet:5.0                                                                                                                                    0.0s
 => [build-env 1/5] FROM mcr.microsoft.com/dotnet/sdk:5.0@sha256:c05f1855774c8472961952f0b3ae5da61f3f959da77ea5f3318e39e780ccd5f3                                                             0.0s
 => [internal] load build context                                                                                                                                                             0.1s
 => => transferring context: 19.73kB                                                                                                                                                          0.1s
 => CACHED [build 2/7] WORKDIR /src                                                                                                                                                           0.0s
 => [build 3/7] COPY [LocationService.csproj, .]                                                                                                                                              0.0s
 => [build 4/7] RUN dotnet restore "./LocationService.csproj"                                                                                                                               231.0s
 => CACHED [stage-1 2/3] WORKDIR /app                                                                                                                                                         0.0s
 => [build 5/7] COPY . .                                                                                                                                                                      0.0s
 => [build 6/7] WORKDIR /src/.                                                                                                                                                                0.0s
 => [build 7/7] RUN dotnet build "LocationService.csproj" -c Release -o /app/build                                                                                                            4.6s
 => [publish 1/1] RUN dotnet publish "LocationService.csproj" -c Release -o /app/publish                                                                                                      3.4s
 => CACHED [final 1/2] WORKDIR /app                                                                                                                                                           0.0s
 => [final 2/2] COPY --from=publish /app/publish .                                                                                                                                            0.1s
 => exporting to image                                                                                                                                                                        0.1s
 => => exporting layers                                                                                                                                                                       0.1s
 => => writing image sha256:5cc9d705fce4c01aa051355701977fab835661598f0c4840b609969509007870                                                                                                  0.0s
 => => naming to docker.io/damilolaadegunwa/locationservice-webapi