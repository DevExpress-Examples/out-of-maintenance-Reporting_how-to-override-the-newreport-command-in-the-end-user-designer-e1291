<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602116/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1291)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraForm1.cs](./CS/XtraForm1.cs) (VB: [XtraForm1.vb](./VB/XtraForm1.vb))
<!-- default file list end -->
# How to override the NewReport command in the End-User Designer


<p>The following example demonstrates how to override the NewReport report command in the End-User Designer. It demonstrates how to perform the following actions when an end-user clicks on the New button:<br />
1. Show a Report Chooser form to select whether to create a simple blank report (an XtraReport class instance), or create a custom report inherited from another report.<br />
2. Instantiate a report of the selected type and open it in the design panel via the XRDesignPanel.OpenReport method.</p>

<br/>


