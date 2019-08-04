using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

Pass typeof(Push) to AppCenter.Start() to add the service:


AppCenter.Start("46a85955-5e35-488e-bbe1-588e10998acd", typeof(Analytics));