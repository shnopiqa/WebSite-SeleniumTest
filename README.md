## Локальное развертывание проетка
### Требовавния к системе для локального развертывания 
1. .NET 6 
2. Visual studio 2022 
3. Бд MsSQL 2022 (Если у вас другая БД, то необходимо установить пакет Entity framework для вашей локальной БД см. инструкции по настройки миграции в БД)
### Пакеты используемые в проекте сервера: 
1. AutoMapper" Version="12.0.0" 
1. AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.0"
1. Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.11" 
1. Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.11"
1. Microsoft.EntityFrameworkCore.Tools" Version="6.0.11"
### Пакеты используемые в проекте клиента 
1. Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.17.0" 
1. Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.11" 
1. Newtonsoft.Json" Version="13.0.2"
### Пакеты используемые в проекте Selenium test 
1. DotNetSeleniumExtras.PageObjects.Core" Version="4.3.0" 
1. Microsoft.NET.Test.Sdk" Version="17.4.1" 
1. Microsoft.VisualStudio.Azure.Containers.Tools.Targets" Version="1.17.0" 
1. Newtonsoft.Json" Version="13.0.2" 
1. Selenium.Support" Version="4.7.0" 
1. elenium.WebDriver" Version="4.7.0" 
1. Selenium.WebDriver.ChromeDriver" Version="108.0.5359.7100" 
1. SeleniumExtras.WaitHelpers" Version="1.0.2" 
1. xunit" Version="2.4.2" 
1. xunit.assert" Version="2.4.2" 
1.xunit.runner.visualstudio" Version="2.4.5
### Настройка миграции в локальную БД
#### Если используется БД MSSql
1. В проекте WebFlash.Service.API.ProductApi открыть файл appsettings.json 
1. В настройке DefaultConnection прописать локальный адрес БД которую вы будете использовать 
1. В поиске visual studio найти консоль диспетчера пакетов и активировать окно
1. В консоли выполнить команду add-migration {Название миграции}
1. После успещной миграции выполнить команду update-database 
#### Если используется другая БД 
1. В проекте WebFlash.Service.API.ProductApi нажать праавую кнопку мыши 
1. Выбрать пункт управление пакетами NuGet 
1. Установить пакет Microsoft.EntityFrameworkCore.{Название вашей БД}


