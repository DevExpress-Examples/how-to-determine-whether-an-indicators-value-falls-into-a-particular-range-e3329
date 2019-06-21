<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DXGauge_RangeEvents/MainPage.xaml) (VB: [MainPage.xaml](./VB/DXGauge_RangeEvents/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DXGauge_RangeEvents/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DXGauge_RangeEvents/MainPage.xaml.vb))
<!-- default file list end -->
# How to determine whether an indicator's value falls into a particular range
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3329)**
<!-- run online end -->


<p>In some cases, you need to know whether or not the current value of an indicator belongs to a particular range. This example shows how to create a state indicator that changes its color depending on the current range. </p><p><br />
</p>


<h3>Description</h3>

<p>In this example, the Circular gauge is created with three ranges and two empty sections. Initially the gauge&#39;s needle doesn&#39;t belong to any range, so the state indicator is painted as a gray ellipse.</p><p>To solve this task it&#39;s necessary to handle the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGaugesRangeBase_IndicatorEntertopic"><u>IndicatorEnter</u></a> and <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGaugesRangeBase_IndicatorLeavetopic"><u>IndicatorLeave</u></a> events in the following way:<br />
- if a needle &#39;enters&#39; a range, it becomes painted with a range color;<br />
- if a needle &#39;leaves&#39; a range, it becomes painted in gray.</p><p>Note: In this example we set the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfGaugesValueIndicatorBase_IsInteractivetopic"><u>IsInteractive</u></a> property to<strong> True</strong>, so that you can click on a gauge and manually change the current needle value.</p><p><br />
</p><br />


<br/>


