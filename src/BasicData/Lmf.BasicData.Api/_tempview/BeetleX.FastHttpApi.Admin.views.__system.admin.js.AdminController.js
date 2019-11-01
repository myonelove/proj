function _Admin() {
    this.url_CloseClients = '/__system/admin/CloseClients';
    this.url_ListClients = '/__system/admin/ListClients';
    this.url_ListRewrite = '/__system/admin/ListRewrite';
    this.url_SaveRewrite = '/__system/admin/SaveRewrite';
    this.url_RemoveRewrite = '/__system/admin/RemoveRewrite';
    this.url_GetStatus = '/__system/admin/GetStatus';
    this.url_GetIPTables = '/__system/admin/GetIPTables';
    this.url_SaveIPTables = '/__system/admin/SaveIPTables';
    this.url_SetActionInfo = '/__system/admin/SetActionInfo';
    this.url_ListActions = '/__system/admin/ListActions';
    this.url_GetDayStats = '/__system/admin/GetDayStats';
    this.url_SummaryUrl = '/__system/admin/SummaryUrl';
    this.url_ListLog = '/__system/admin/ListLog';
    this.url_GetVersions = '/__system/admin/GetVersions';
    this.url_CreateTokenKey = '/__system/admin/CreateTokenKey';
    this.url_ChangeLogLevel = '/__system/admin/ChangeLogLevel';
    this.url_ChangePassword = '/__system/admin/ChangePassword';
    this.url_GetSetting = '/__system/admin/GetSetting';
    this.url_Login = '/__system/admin/Login';
    this.url_Signout = '/__system/admin/Signout';
}
/**
* 'CloseClients(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.CloseClients = function (ids, useHttp) {
    return api(this.url_CloseClients, { ids: ids }, useHttp, true);
}
/**
* 'ListClients(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ListClients = function (index, useHttp) {
    return api(this.url_ListClients, { index: index }, useHttp);
}
/**
* 'ListRewrite(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ListRewrite = function (useHttp) {
    return api(this.url_ListRewrite, {}, useHttp);
}
/**
* 'SaveRewrite(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.SaveRewrite = function (rewrite, useHttp) {
    return api(this.url_SaveRewrite, { rewrite: rewrite }, useHttp, true);
}
/**
* 'RemoveRewrite(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.RemoveRewrite = function (url, useHttp) {
    return api(this.url_RemoveRewrite, { url: url }, useHttp);
}
/**
* 'GetStatus(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.GetStatus = function (useHttp) {
    return api(this.url_GetStatus, {}, useHttp);
}
/**
* 'GetIPTables(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.GetIPTables = function (useHttp) {
    return api(this.url_GetIPTables, {}, useHttp);
}
/**
* 'SaveIPTables(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.SaveIPTables = function (config, useHttp) {
    return api(this.url_SaveIPTables, { config: config }, useHttp, true);
}
/**
* 'SetActionInfo(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.SetActionInfo = function (actionid, settings, useHttp) {
    return api(this.url_SetActionInfo, { actionid: actionid, settings: settings }, useHttp, true);
}
/**
* 'ListActions(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ListActions = function (useHttp) {
    return api(this.url_ListActions, {}, useHttp);
}
/**
* 'GetDayStats(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.GetDayStats = function (useHttp) {
    return api(this.url_GetDayStats, {}, useHttp);
}
/**
* 'SummaryUrl(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.SummaryUrl = function (useHttp) {
    return api(this.url_SummaryUrl, {}, useHttp);
}
/**
* 'ListLog(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ListLog = function (index, useHttp) {
    return api(this.url_ListLog, { index: index }, useHttp);
}
/**
* 'GetVersions(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.GetVersions = function (useHttp) {
    return api(this.url_GetVersions, {}, useHttp);
}
/**
* 'CreateTokenKey(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.CreateTokenKey = function (useHttp) {
    return api(this.url_CreateTokenKey, {}, useHttp);
}
/**
* 'ChangeLogLevel(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ChangeLogLevel = function (type, logCacheSize, useHttp) {
    return api(this.url_ChangeLogLevel, { type: type, logCacheSize: logCacheSize }, useHttp);
}
/**
* 'ChangePassword(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.ChangePassword = function (pwd, useHttp) {
    return api(this.url_ChangePassword, { pwd: pwd }, useHttp);
}
/**
* 'GetSetting(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.GetSetting = function (useHttp) {
    return api(this.url_GetSetting, {}, useHttp);
}
/**
* 'Login(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.Login = function (name, password, useHttp) {
    return api(this.url_Login, { name: name, password: password }, useHttp);
}
/**
* 'Signout(params).execute(function(result){});'
* 'FastHttpApi javascript api Generator Copyright © henryfan 2018 email:henryfan@msn.com
* 'https://github.com/IKende/FastHttpApi
**/
_Admin.prototype.Signout = function (useHttp) {
    return api(this.url_Signout, {}, useHttp);
}
