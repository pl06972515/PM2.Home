<h1 align="center">Newbe.ObjectVisitor</h1>
<p align="center">
</p><br/>







>[!WARNING|style: flat|label: 简要说明]
>
>帮助开发者可以用最简单的最高效的方式[ 访问一个普通`class`的所有属性 ]<span style='color:Blue'>[ 从而实现：验证、映射、收集等等操作 ]</span>
>
>- <span style='color:red'>[ 效率 ]</span>类库使用[ 表达式树实现 ]，因此它拥有比直接使用反射快上`10`倍的性能
>- <span style='color:red'>[ 可读性 ]</span>通过类库，可以使用[`链式 API`]和[`命名方法`]来创建一个委托
>- <span style='color:red'>[ 扩展性 ]</span>通过类库，可以更简便的方式来访问[ 一个类所有的属性 ]
>
>---
>
>
>
>- <a href="https://github.com/newbe36524/Newbe.ObjectVisitor/blob/main/README_zh_Hans.md" target="_blank"><img src="https://img.shields.io/badge/NuGet-Newbe.ObjectVisitor-orange?style=plastic&labelColor=004880&logo=NuGet" /></a>
>
>- [<span style='color:#008B00'>[👓 官方帮助文档 ]</span>](http://cn.ov.newbe.pro/zh/001-quick-started/002-create-and-cache-your-object-visitor ':target=_blank')
>
>---
>
><span style='color:red'>[ 案例说明 ]</span>创建一个简单的数据模型，通过`String`实现拼接其所有属性的业务逻辑
>
>```csharp
>public class OrderInfo
>{
>    
>       public int ID { get; set; }
>       public string Name { get; set; }
>       public decimal TotalPrice { get; set; }
>    
>}
>
>```
>
><br/>

<!-- tabs:start -->

#### **常规实现**

```csharp
var order = new OrderInfo
{
      ID = 1,
      Name = "张三",
      TotalPrice = 100M
};

var sb = new StringBuilder();
sb.AppendFormat("{0}: {1}{2}", nameof(order.ID), order.ID, Environment.NewLine);
sb.AppendFormat("{0}: {1}{2}", nameof(order.Name), order.Name, Environment.NewLine);
sb.AppendFormat("{0}: {1}{2}", nameof(order.TotalPrice), order.TotalPrice, Environment.NewLine);

Console.WriteLine(sb.ToString());

```



#### **Object Visitor**

```csharp
var order = new OrderInfo
{
      ID = 1,
      Name = "张三",
      TotalPrice = 100M
};
var sb = new StringBuilder();

var visitor = order.V()
                   .ForEach((name, value) => sb.AppendFormat("{0}: {1}{2}", name, value, Environment.NewLine));
visitor.Run();
Console.WriteLine(sb.ToString());

```





<!-- tabs:end -->



