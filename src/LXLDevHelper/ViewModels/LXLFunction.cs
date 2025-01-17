﻿using Newtonsoft.Json;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace LXLDevHelper.ViewModels
{
    public class LXLFunctionBase : BindableBase
    {
        /// <summary>
        /// 返回值类型
        /// </summary>
        public string ReturnType { get => _returnType; set => SetProperty(ref _returnType, value); }
        private string _returnType = "";
    }

    /// <summary>
    /// 匿名方法定义
    /// </summary>
    public class LXLFunctionAnonymous : LXLFunctionBase
    {
        /// <summary>
        /// 方法参数
        /// </summary>
        public virtual ObservableCollection<LXLFuncParamsBase> Params { get => _params; set => SetProperty(ref _params, value); }
        private ObservableCollection<LXLFuncParamsBase> _params = new();
        [JsonIgnore] public static ObservableCollection<string> AvaliableTypes { get => MainContentViewModel.AvaliableTypes; }
    }
    /// <summary>
    /// 非匿名方法定义
    /// </summary>
    public class LXLFunction : LXLFunctionBase
    {
        [JsonIgnore] public LXLFunction Me { get => this; }
        /// <summary>
        /// 方法描述
        /// </summary>
        public string Description { get => _description; set => SetProperty(ref _description, value); }
        private string _description =
#if DEBUG
"方法描述"
#else
""
#endif
            ;
        /// <summary>
        /// 方法名
        /// </summary>
        public string FuncName { get => _funcName; set => SetProperty(ref _funcName, value); }
        private string _funcName =
#if DEBUG
"方法名称"
#else
""
#endif
            ;
        ///// <summary>
        ///// 返回值名
        ///// </summary>
        //public string ReturnName { get => _returnName; set => SetProperty(ref _returnName, value); }
        //private string _returnName = "";
        /// <summary>
        /// 返回值描述
        /// </summary>
        public string ReturnDescription { get => _returnDescription; set => SetProperty(ref _returnDescription, value); }
        private string _returnDescription = "";
        /// <summary>
        /// 是否静态方法
        /// </summary>
        public bool IsStatic { get => _isStatic; set => SetProperty(ref _isStatic, value); }
        private bool _isStatic = false;
        /// <summary>
        /// 方法参数
        /// </summary>
        public ObservableCollection<LXLFuncParams> Params { get => _params; set => SetProperty(ref _params, value); }
        private ObservableCollection<LXLFuncParams> _params = new();
    }
}
