function Management() {
    this.url_Login = '/__system/bumblebee/management/Login';
    this.url_GetMaxValues = '/__system/bumblebee/management/GetMaxValues';
    this.url_PluginEnabled = '/__system/bumblebee/management/PluginEnabled';
    this.url_SavePluginSetting = '/__system/bumblebee/management/SavePluginSetting';
    this.url_GetPlugin = '/__system/bumblebee/management/GetPlugin';
    this.url_GetVersions = '/__system/bumblebee/management/GetVersions';
    this.url_ListPluginInfos = '/__system/bumblebee/management/ListPluginInfos';
    this.url_GetUrlSummary = '/__system/bumblebee/management/GetUrlSummary';
    this.url_ServiceStatus = '/__system/bumblebee/management/ServiceStatus';
    this.url_Status = '/__system/bumblebee/management/Status';
    this.url_Signout = '/__system/bumblebee/management/Signout';
    this.url_CreateTokenKey = '/__system/bumblebee/management/CreateTokenKey';
    this.url_ChangeLogLevel = '/__system/bumblebee/management/ChangeLogLevel';
    this.url_ChangePassword = '/__system/bumblebee/management/ChangePassword';
    this.url_GetSetting = '/__system/bumblebee/management/GetSetting';
    this.url_ListServerCategories = '/__system/bumblebee/management/ListServerCategories';
    this.url_AddServer = '/__system/bumblebee/management/AddServer';
    this.url_SetServers = '/__system/bumblebee/management/SetServers';
    this.url_ListServer = '/__system/bumblebee/management/ListServer';
    this.url_RemoveServer = '/__system/bumblebee/management/RemoveServer';
    this.url_ListRoute = '/__system/bumblebee/management/ListRoute';
    this.url_RouteSetting = '/__system/bumblebee/management/RouteSetting';
    this.url_SetRoute = '/__system/bumblebee/management/SetRoute';
    this.url_GetDayStatic = '/__system/bumblebee/management/GetDayStatic';
    this.url_ListLog = '/__system/bumblebee/management/ListLog';
    this.url_RemoveRoute = '/__system/bumblebee/management/RemoveRoute';
    this.url_ListRouteServers = '/__system/bumblebee/management/ListRouteServers';
    this.url_SetRouteServers = '/__system/bumblebee/management/SetRouteServers';
    this.url_SetRouteServer = '/__system/bumblebee/management/SetRouteServer';
    this.url_RemoveRouteServer = '/__system/bumblebee/management/RemoveRouteServer';
}
/**
* 'Login(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.Login = function (name, password, useHttp) {
    return api(this.url_Login, { name: name, password: password }, useHttp);
}
/**
* 'GetMaxValues(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetMaxValues = function (useHttp) {
    return api(this.url_GetMaxValues, {}, useHttp);
}
/**
* 'PluginEnabled(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.PluginEnabled = function (name, enabled, useHttp) {
    return api(this.url_PluginEnabled, { name: name, enabled: enabled }, useHttp);
}
/**
* 'SavePluginSetting(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.SavePluginSetting = function (name, setting, useHttp) {
    return api(this.url_SavePluginSetting, { name: name, setting: setting }, useHttp, true);
}
/**
* 'GetPlugin(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetPlugin = function (name, useHttp) {
    return api(this.url_GetPlugin, { name: name }, useHttp);
}
/**
* 'GetVersions(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetVersions = function (useHttp) {
    return api(this.url_GetVersions, {}, useHttp);
}
/**
* 'ListPluginInfos(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListPluginInfos = function (useHttp) {
    return api(this.url_ListPluginInfos, {}, useHttp);
}
/**
* 'GetUrlSummary(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetUrlSummary = function (useHttp) {
    return api(this.url_GetUrlSummary, {}, useHttp);
}
/**
* 'ServiceStatus(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ServiceStatus = function (useHttp) {
    return api(this.url_ServiceStatus, {}, useHttp);
}
/**
* 'Status(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.Status = function (useHttp) {
    return api(this.url_Status, {}, useHttp);
}
/**
* 'Signout(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.Signout = function (useHttp) {
    return api(this.url_Signout, {}, useHttp);
}
/**
* 'CreateTokenKey(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.CreateTokenKey = function (useHttp) {
    return api(this.url_CreateTokenKey, {}, useHttp);
}
/**
* 'ChangeLogLevel(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ChangeLogLevel = function (type, logCacheSize, useHttp) {
    return api(this.url_ChangeLogLevel, { type: type, logCacheSize: logCacheSize }, useHttp);
}
/**
* 'ChangePassword(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ChangePassword = function (pwd, useHttp) {
    return api(this.url_ChangePassword, { pwd: pwd }, useHttp);
}
/**
* 'GetSetting(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetSetting = function (useHttp) {
    return api(this.url_GetSetting, {}, useHttp);
}
/**
* 'ListServerCategories(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListServerCategories = function (useHttp) {
    return api(this.url_ListServerCategories, {}, useHttp);
}
/**
* 'AddServer(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.AddServer = function (host, maxConnections, useHttp) {
    return api(this.url_AddServer, { host: host, maxConnections: maxConnections }, useHttp);
}
/**
* 'SetServers(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.SetServers = function (items, useHttp) {
    return api(this.url_SetServers, { items: items }, useHttp, true);
}
/**
* 'ListServer(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListServer = function (useHttp) {
    return api(this.url_ListServer, {}, useHttp);
}
/**
* 'RemoveServer(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.RemoveServer = function (server, useHttp) {
    return api(this.url_RemoveServer, { server: server }, useHttp);
}
/**
* 'ListRoute(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListRoute = function (useHttp) {
    return api(this.url_ListRoute, {}, useHttp);
}
/**
* 'RouteSetting(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.RouteSetting = function (setting, useHttp) {
    return api(this.url_RouteSetting, { setting: setting }, useHttp, true);
}
/**
* 'SetRoute(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.SetRoute = function (url, remark, hashPattern, useHttp) {
    return api(this.url_SetRoute, { url: url, remark: remark, hashPattern: hashPattern }, useHttp);
}
/**
* 'GetDayStatic(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.GetDayStatic = function (useHttp) {
    return api(this.url_GetDayStatic, {}, useHttp);
}
/**
* 'ListLog(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListLog = function (index, useHttp) {
    return api(this.url_ListLog, { index: index }, useHttp);
}
/**
* 'RemoveRoute(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.RemoveRoute = function (url, useHttp) {
    return api(this.url_RemoveRoute, { url: url }, useHttp);
}
/**
* 'ListRouteServers(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.ListRouteServers = function (url, useHttp) {
    return api(this.url_ListRouteServers, { url: url }, useHttp);
}
/**
* 'SetRouteServers(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.SetRouteServers = function (url, servers, useHttp) {
    return api(this.url_SetRouteServers, { url: url, servers: servers }, useHttp);
}
/**
* 'SetRouteServer(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.SetRouteServer = function (url, server, weight, maxRps, useHttp) {
    return api(this.url_SetRouteServer, { url: url, server: server, weight: weight, maxRps: maxRps }, useHttp);
}
/**
* 'RemoveRouteServer(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
Management.prototype.RemoveRouteServer = function (url, server, useHttp) {
    return api(this.url_RemoveRouteServer, { url: url, server: server }, useHttp);
}
