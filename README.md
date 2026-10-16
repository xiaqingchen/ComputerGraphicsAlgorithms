# 计算机图形学基本算法

基于 **C#** 和 **Windows Forms** 实现的计算机图形学基本算法演示项目。

本项目主要用于学习和实现计算机图形学中的基本图形生成与扫描转换算法，通过 Windows Forms 图形界面选择不同算法，并将算法生成的像素点显示在画布中。

## 开发环境

| 项目 | 内容 |
|---|---|
| 编程语言 | C# |
| 开发环境 | Visual Studio |
| 项目类型 | Windows Forms App (.NET Framework) |
| .NET Framework | 4.8.1 |
| 操作系统 | Windows |
| 图形显示 | Windows Forms + Bitmap |


## 项目结构

ComputerGraphicsAlgorithms/
│
├─ Algorithms/
│  └─ GraphicsAlgorithms.cs
│
├─ Models/
│  └─ PixelPoint.cs
│
├─ MainForm.cs
├─ MainForm.Designer.cs
├─ MainForm.resx
├─ Program.cs
├─ App.config
└─ ComputerGraphicsAlgorithms.csproj

### Algorithms

`GraphicsAlgorithms.cs`

负责实现主要的计算机图形学算法，包括：

- DDA 直线算法
- 中点画线算法
- Bresenham 直线算法
- 中点画圆算法
- Bresenham 画圆算法
- 中点椭圆算法

算法计算完成后返回由 `PixelPoint` 组成的像素点集合。

### Models

`PixelPoint.cs`

定义像素点数据结构：

public struct PixelPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}

用于保存需要绘制的像素坐标。

### MainForm

`MainForm.cs`

负责 Windows Forms 界面以及用户操作。

用户可以通过不同按钮执行对应算法，并将计算得到的像素点显示在绘图区中。

### MainForm.Designer.cs

由 Windows Forms Designer 自动生成，用于创建和初始化界面控件。

### Program.cs

程序入口，启动 Windows Forms 主窗口。


## 界面操作

程序运行后，可以通过左侧参数输入区域输入算法所需参数。

主要按钮包括：

生成点
DDA直线
中点画线
Bresenham直线
中点画圆
Bresenham画圆
中点椭圆
清空

绘图区用于显示算法生成的像素点。

## 坐标系统

当前版本使用 Windows Forms 的屏幕坐标系统：

(0,0) ───────────────→ X
  │
  │
  │
  ↓
  Y

其中：

- 左上角为 `(0, 0)`
- X 轴向右增加
- Y 轴向下增加

## 核心实现方式

本项目采用：

输入图形参数
      ↓
图形生成算法
      ↓
计算像素点集合
      ↓
List<PixelPoint>
      ↓
Bitmap.SetPixel()
      ↓
Windows Forms 画布

例如直线算法最终得到：

List<PixelPoint>

然后程序逐个设置 Bitmap 中对应位置的像素。

这种实现方式可以更直观地观察和学习光栅图形生成算法。


## 运行项目

### 方法一：Visual Studio

使用 Visual Studio 打开：

ComputerGraphicsAlgorithms.sln

然后：

1. 确认目标框架为 `.NET Framework 4.8.1`
2. 设置 `ComputerGraphicsAlgorithms` 为启动项目
3. 点击 **生成 → 生成解决方案**
4. 点击 **调试 → 开始执行**

即可运行程序。


## 编译输出

项目编译后，可以在项目目录下找到类似：

ComputerGraphicsAlgorithms/
└─ bin/
   └─ Release/
      └─ ComputerGraphicsAlgorithms.exe

具体输出位置取决于 Visual Studio 当前选择的配置。

> 注意：本项目使用 .NET Framework 4.8.1，因此目标计算机需要具备相应的 .NET Framework 环境。


## 项目目的

本项目主要用于学习和实践计算机图形学中的基本图形生成算法。

通过将算法计算出的像素点直接显示出来，可以更加直观地理解：

- 光栅化
- 像素点生成
- 直线扫描转换
- 圆的对称性
- 椭圆的区域划分
- 决策参数
- 整数增量计算

以及不同图形生成算法之间的实现方式和特点。
