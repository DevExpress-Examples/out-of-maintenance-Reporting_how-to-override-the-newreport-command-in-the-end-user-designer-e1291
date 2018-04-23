# How to override the NewReport command in the End-User Designer


<p>The following example demonstrates how to override the NewReport report command in the End-User Designer. It demonstrates how to perform the following actions when an end-user clicks on the New button:<br />
1. Show a Report Chooser form to select whether to create a simple blank report (an XtraReport class instance), or create a custom report inherited from another report.<br />
2. Instantiate a report of the selected type and open it in the design panel via the XRDesignPanel.OpenReport method.</p>

<br/>


