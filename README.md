# serverless-helloworld

##  simple aws lambda using [serverless platform](https://serverless.com/framework/docs/providers/aws/examples/hello-world/csharp/#1-create-a-service) and .net core


1) Install serverless:

``` 
npm install -g serverless_ 
```

2. Setup AWS Credentials

``` 
serverless config credentials --provider aws --key AKIAIOSFODNN7EXAMPLE --secret wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY 
```

3. Create project

``` 
serverless  create --template aws-csharp --path myService 
```

4. Add nuget package for api gateway models

``` 
dotnet add package Amazon.Lambda.APIGatewayEvents 
```

5. Build

``` 
./build.cmd (on win)
./build.sh (on mac)  

```

6. Deploy

``` 
serverless deploy 
```
