<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [XtraForm1.vb](./VB/XtraForm1.vb))
* [Report1.cs](./CS/Report1.cs) (VB: [Report1.vb](./VB/Report1.vb))
* [Report2.cs](./CS/Report2.cs) (VB: [Report2.vb](./VB/Report2.vb))
* [XtraForm1.cs](./CS/XtraForm1.cs) (VB: [XtraForm1.vb](./VB/XtraForm1.vb))
<!-- default file list end -->
# How to override the NewReport command in the End-User Designer


<p>The following example demonstrates how to override the NewReport report command in the End-User Designer. It demonstrates how to perform the following actions when an end-user clicks on the New button:<br />
1. Show a Report Chooser form to select whether to create a simple blank report (an XtraReport class instance), or create a custom report inherited from another report.<br />
2. Instantiate a report of the selected type and open it in the design panel via the XRDesignPanel.OpenReport method.</p>

<br/>


