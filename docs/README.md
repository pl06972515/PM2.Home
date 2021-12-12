<h1 align="center">PM2.Home</h1>
<p align="center">
</p><br/>








>[!WARNING|style: flat|label: 简要说明]
>
>[`PM2.HomeAbstract`]首页模板化，可帮助开发者快速实现[ 首页豆腐块相关业务 ]
>
>- <a href="./wwwroot/UML/PM2.HomeAbstract.drawio.html" target="_blank"><img src="https://img.shields.io/badge/UML-FCC624?style=plastic&logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAABX0lEQVQ4T52TPyvFcRTGP49MSmTwp7wHFouFQXeQVyBJyrW4g0IGt+vPIMnkLiiJwQsw3JJSBiPlBVgxKINFqUfn9vvdfq7/vuPpnM85z3POV/zi2e6UdP9Zqn6qt90IPAErkjbr838DGATOgWFJlf8A1oFZoEXSy7cA21NAPzApyZFs+wp4BHLAPnApaS8F1STYngG2gUNgIgC224EHYB7YAg6AcSCfQqoA23NAGBTk6Uz3MeAI6JF0Yzvyd4CYtCCpHG2KwCpQllTIarQdxTlJHXXx3QRSDMASsPYFIMavSJqoA4TUkFxMJZSA5awE273ANTAq6TiRmpVQkrSaNTGlVk0EFoBYYZukp0R/amJN7rtDsh3F3cAQcAY0S+pLujcAp8CtpPyHNWaSmmIxyfluSAqPqs92M/Ccbilin56y7RHgBBiQdPHdf/kKsAhE51ZJr38GJON2Sbr76be+ARXylwMoSE5uAAAAAElFTkSuQmCC" /></a>
>
>- <a href="https://github.com/pl06972515/PM2.Home" target="_blank"><img src="https://img.shields.io/badge/NuGet-PM2.Home-orange?style=plastic&labelColor=004880&logo=NuGet" /></a>
>
>- [`namespace: PM2.Home`]
>
>  <br>
>




>[!NOTE|style: flat|label: yaml - 配置参数介绍]
>
>- `HomeType`配置类型
>
>  \- [`Custom`]自定义
>
>  \- [`Report`]标准报表
>
>  \- [`CircChart`]饼状图
>
>  \- [`HistoChart`]柱状图
>
>  \- [`LineChart`]折线图
>
>  \- [`PanelChart`]仪表盘
>
>  <br/>
>
>- `Regex`匹配模式(`正则表达式`)
>
>- `ConfigFullName`配置完全限定名称(`IHomeConfig`)
>
>- `SlidingExpiration`缓存(`单位: 秒, -1 禁用缓存`)
>
>- `IsEnable`配置是否生效(`True | False`)
>
>```yaml
>##  案例说明  ##
>- #首页顶部(新签合同书, 新中标项目, 我的待审批, 我的新任务, 公司公告) 
>  HomeType: Custom 
>  Regex: "^Top$" 
>  ConfigFullName: 'PM2.Home.Config.TopHomeConfig' 
>  SlidingExpiration: 60 
>  IsEnable: True
>
>- #标注报表 
>  HomeType: Report 
>  Regex: "^T?3000305$" 
>  ConfigFullName: 'PM2.Home.Config.NoticeHomeConfig' 
>  SlidingExpiration: 60 
>  IsEnable: True
>
>- #饼状图 
>  HomeType: CircChart 
>  Regex: "^T?3000409$" 
>  ConfigFullName: 'PM2.Home.Config.CircDemoHomeConfig' 
>  SlidingExpiration: 60 
>  IsEnable: True
>  
>- #柱状图 
>  HomeType: HistoChart 
>  Regex: "^T?3000605$" 
>  ConfigFullName: 'PM2.Home.Config.HistoDemoHomeConfig' 
>  SlidingExpiration: 60 
>  IsEnable: True
>
>- #折线图 
>  HomeType: LineChart 
>  Regex: "^T?3000905$" 
>  ConfigFullName: 'PM2.Home.Config.LineDemoHomeConfig' 
>  SlidingExpiration: 60 
>  IsEnable: True
>
>```
>
><br/>



