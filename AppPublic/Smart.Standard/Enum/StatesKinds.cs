﻿using System;
using Smart.Standard.Attribute;

namespace Smart.Standard.Enum
{
    /// <summary>
    /// 状态枚举
    /// </summary>
    [EnumDescription("状态枚举")]
    [Flags]
    public enum StatesKinds
    {
        /// <summary>
        /// 可用
        /// </summary>
        [EnumDescription("可用")]
        Enable = 1,
        /// <summary>
        /// 不可用
        /// </summary>
        [EnumDescription("不可用")]
        DissEnable = 1 << 1,
        /// <summary>
        /// 移除
        /// </summary>
        [EnumDescription("移除")]
        Remove = 1 << 2,
        /// <summary>
        /// 到期
        /// </summary>
        [EnumDescription("到期")]
        Expire = 1 << 3,
        /// <summary>
        /// 锁定
        /// </summary>
        [EnumDescription("锁定")]
        Lock = 1 << 4,
        /// <summary>
        /// 解锁
        /// </summary>
        [EnumDescription("解锁")]
        UnLock = 1 << 5
    }
}
