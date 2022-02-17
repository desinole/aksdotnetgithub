# AKS dotnet GitHub

In this exercise, we will compile, containerize and deploy a .NET6 app to an AKS cluster using GitHub Actions.

We will evolve the app, actions and AKS concepts as we go along

## Stage 1

1. Create and containerize a .NET6 app

```PowerShell   
dotnet new blazorserver -o BlazorApp --no-https
```

Follow the directions in this [tutorial](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create) to create blazor app

Follow the direction in this [tutorial](https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-server-app/) to containerize the app



2. Create a basic AKS cluster with supporting ACR

3. Deploy the app to the cluster with GitHub Actions.