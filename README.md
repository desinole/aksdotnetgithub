# AKS dotnet GitHub

[![build](https://github.com/desinole/aksdotnetgithub/actions/workflows/build-validation.yml/badge.svg)](https://github.com/desinole/aksdotnetgithub/actions/workflows/build-validation.yml)

In this exercise, we will compile, containerize and deploy a .NET6 app to an AKS cluster using GitHub Actions.

We will evolve the app, actions and AKS concepts as we go along

## Stage 1

1. Create and containerize a .NET6 app

```PowerShell   
dotnet new blazorserver -o BlazorApp --no-https
```

Follow the directions in this [tutorial](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/create) to create blazor app

Also review [Build a web app with Blazor](https://docs.microsoft.com/en-us/learn/modules/build-blazor-webassembly-visual-studio-code/?WT.mc_id=dotnet-35129-website)

Follow the direction in this [tutorial](https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-server-app/) to containerize the app

Setup Blazor Tests
[1](https://medium.com/younited-tech-blog/unit-test-a-blazor-component-729eec4eab01)
[2](https://bunit.dev/docs/getting-started/writing-tests.html?tabs=xunit)


2. Create a basic AKS cluster with supporting ACR

3. Deploy the app to the cluster with GitHub Actions.