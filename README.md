# Mbp
- Mbp是一个.net core 3的web开发框架.而如今,.net core已经在大数据,人工智能,容器云化方面取得相当大的进步.借此,本着学习的态度,也想在转型到大数据方面做一个铺垫,所以开始了这第一步,整合一个基于.net core的开发框架.此框架借鉴了国外优秀开源项目abp vnext,及国内优秀开源框架Osharp的一些思想和实现.
- 欢迎各路开发爱好者加入这个项目.我们将以**Scrum敏捷框架 + azure devops协同工具**的方式进行协作喔,也是为了后期的容器云化做准备.
### Mbp的未来,123方面
#### 1.成为一个rest api的开发框架
**平台提供能力**
- 模块化,包含.net core核心模块和aspnetcore核心模块
- 基于Jwt的统一身份认证
- 基于角色和自定义策略的统一授权系统
- 集成Swagger ui的poco controller.
- 集成ef core
- 提供了Aop机制
- 后续将陆续集成,Hangfire,IentityServer4,NServiceBus,RabbitMQ,SignalR,Redis,ML,ES,Multitenancy,virtualfilesystem等等,这些将不按特定顺序集成进来喔,很多好玩的等着你喔,快来一起玩吧.
- 最后将会实施容器化,使用linux docker container来运行我们的.net core程序.使用K8S来管理我们的micro services.
#### 2.成为一个可视化建模的平台
**平台提供能力**
- 目前是空白喔.计划的123是这样的:
- 1.提供一个主框架,提供基础主数据的管理功能,比如租户,人员,角色,权限,存储等管理
- 2.提供一个可视化UI建模平台,让代码量降到最低,只需要拖拉拽就可以开发一个精美的小系统喔,实现让机器干活,人来思考,嘻嘻.
- 3.欢迎前端开发爱好者加入这个项目,我们一起玩架构,玩设计,玩编程.
#### 3.成为一个Big Data,AI的基础服务平台
**平台提供能力**
- 未完待续

### Mbp开发规划概要

- 1.0.0提供一个企业级的解决方案开发框架.(2019.12月发布)
- 1.1.0提供二次开发扩展能力(2020.1月发布)
- 1.2.0提供多租户功能.(2020.2月发布)
- 1.3.0提供数据建模能力(2020.3月发布)
- 1.4.0提供模块,页面(列表,表单,窗体...)建模能力(2020.6月发布)
- 1.5.0优化UI建模(2020.8月发布)
- 持续优化中
- 2.0.0提供通用场景的UI建模能力(2020.7月发布)
