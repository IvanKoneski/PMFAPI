/*
 * Personal Finance Management API
 *
 * Personal Finance Management API allows analyze of a client's spending patterns against pre-defined budgets over time 
 *
 * OpenAPI spec version: v1
 * Contact: aleksandar.milosevic@asseco-see.rs
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APIPMF.Models
{ 
        /// <summary>
        /// Enumeration that distinguishes between accounting transactions based on their effect on the customer accounts.
        /// </summary>
        /// <value>Enumeration that distinguishes between accounting transactions based on their effect on the customer accounts.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransactionKindsEnum
        {
            /// <summary>
            /// Enum DepEnum for dep
            /// </summary>
            [EnumMember(Value = "dep")]
            DepEnum = 0,
            /// <summary>
            /// Enum WdwEnum for wdw
            /// </summary>
            [EnumMember(Value = "wdw")]
            WdwEnum = 1,
            /// <summary>
            /// Enum PmtEnum for pmt
            /// </summary>
            [EnumMember(Value = "pmt")]
            PmtEnum = 2,
            /// <summary>
            /// Enum FeeEnum for fee
            /// </summary>
            [EnumMember(Value = "fee")]
            FeeEnum = 3,
            /// <summary>
            /// Enum IncEnum for inc
            /// </summary>
            [EnumMember(Value = "inc")]
            IncEnum = 4,
            /// <summary>
            /// Enum RevEnum for rev
            /// </summary>
            [EnumMember(Value = "rev")]
            RevEnum = 5,
            /// <summary>
            /// Enum AdjEnum for adj
            /// </summary>
            [EnumMember(Value = "adj")]
            AdjEnum = 6,
            /// <summary>
            /// Enum LndEnum for lnd
            /// </summary>
            [EnumMember(Value = "lnd")]
            LndEnum = 7,
            /// <summary>
            /// Enum LnrEnum for lnr
            /// </summary>
            [EnumMember(Value = "lnr")]
            LnrEnum = 8,
            /// <summary>
            /// Enum FcxEnum for fcx
            /// </summary>
            [EnumMember(Value = "fcx")]
            FcxEnum = 9,
            /// <summary>
            /// Enum AopEnum for aop
            /// </summary>
            [EnumMember(Value = "aop")]
            AopEnum = 10,
            /// <summary>
            /// Enum AclEnum for acl
            /// </summary>
            [EnumMember(Value = "acl")]
            AclEnum = 11,
            /// <summary>
            /// Enum SplEnum for spl
            /// </summary>
            [EnumMember(Value = "spl")]
            SplEnum = 12,
            /// <summary>
            /// Enum SalEnum for sal
            /// </summary>
            [EnumMember(Value = "sal")]
            SalEnum = 13        }
}
