<h1>新建配置WCF服务接口</h1>

<p>
  别人已经新建好的项目和搭配好的服务，自己在上面二次开发不少时间；
  <br/>轮到自己从零开始新建搭建，还是琢磨了不少时间
  <br/>
  虽然未来自己选择的方向也不打算深究后台接口开发
  <br/>
  <b>以下内容权当备忘</b>
  <br/>
  <i>以备不时之需</i>
</p>

<nav>
<p>
  <a href="#createProject">1.新建项目</a><br/>
  <a href="#editWCFConfig">2.编辑WCF配置</a>
</p>
</nav>

<main>
  <article>
    <label id="createProject">新建项目</label>
    <p>1.打开VisualStudio新建项目选择"WCF服务应用程序", 自动生成名称为"WcfService1"</p>
    <p>2.安装两个NuGet包：<i>MsSqlHelper</i>(将自动安装<i>Microsoft.SqlServer.Types</i>)和<i>Newtonsoft.Json</i></p>
  </article>
  <article>
    <label id="editWCFConfig">编辑WCF配置</label>
    <p>1.右键项目目录的<strong>Web.config</strong>文件，选择<strong>编辑WCF配置</strong></p>
    <p>2.在<i>Microsoft Service Configuration Editor</i>窗口中，右键左侧<i>Advanced</i>目录下的<i>Endpoint Behaviors</i>选择<strong>New Endpoint Behavior Configuration</strong></p>
    <p>3.对新的<i>Behavior</i>命名后，选择<strong>Add..</strong>，在<i>Adding Behavior Elemont Extension Sections</i>中选择<strong>webHttp</strong>后点击OK</p>
    <p>4.右键左侧目录的<i>Services</i>项,选择<strong>New Service</strong>，并命名</p>
    <p>5.右键新建的Service下的<i>Endpoints</i>目录,选择<strong>New Service Endpoint</strong></p>
    <p>6.其余内部设定可以对本项目的Web.config的WCF配置照抄(命名与Endpoint的Address可以自由)</p>
  </article>
</main>
