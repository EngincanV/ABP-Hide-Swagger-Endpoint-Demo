# ABP Hide Swagger Endpoints Demo

Enable/Disable Hiding Swagger Endpoints by using the "Setting Management" page.

> In this sample project, we only hide our endpoints that start with the "/api/abp" prefix by definining it in our [`CustomSwaggerFilter`](https://github.com/EngincanV/ABP-Hide-Swagger-Endpoint-Demo/blob/main/src/SwaggerSettingsDemo.Web/Filters/CustomSwaggerFilter.cs#L28). If you want to hide some other endpoints, you can update the class.

![swagger-hide-endpoints](https://user-images.githubusercontent.com/43685404/152680344-af434069-c690-4527-8650-0eec519a3d0a.gif)
