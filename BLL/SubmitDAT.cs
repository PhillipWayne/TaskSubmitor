﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VssTask;
using Model;

namespace BLL
{
    /// <summary>
    /// 提交DAT业务logic处理
    /// </summary>
    public class SubmitDAT
    {
        private Task task;

        /// <summary>
        /// 必须基于Task的构造，如果没有task则不能提交
        /// </summary>
        /// <param name="task"></param>
        public SubmitDAT(Task task)
        {
            this.task = task;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Submit()
        {
            if (this.task == null)
                return;
            //TODO：输入太多，考虑输入jira号之后，由软件自动生成相关文件模板，用户修改添加即可，这样多数路径由软件智能提取
            //任务提交器
            SubmitVssTemplate realSubmitor = new SubmitVssConcrete();
            //输入
            realSubmitor.DesignDocLocalPath = @"D:\Work\Task\已经上线\ABLREQUEST-1083-银保通签发保单之后发送承保短信\ddd.doc";
            //输入
            realSubmitor.TestDocLocalPath = @"D:\Work\Task\ABLREQUEST-1396-团险添加投保率不足0.75的控制提示\ABLREQUEST-1396-团险添加投保率不足0.75的控制提示-自测试报告20121204.doc";
            //输入
            realSubmitor.DocVssFolder = @"$/LIS－CM－AB/05-项目任务/B-契约模块/ABLREQUEST-1396-团险添加投保率不足0.75的控制提示";
            //输入
            realSubmitor.SqlDocLocalFolder = @"D:\Work\Task\已经上线\ABLREQUEST-1083-银保通签发保单之后发送承保短信";
            //配置默认
            realSubmitor.SqlDocVssFolder = @"$/B-更新目录/03-数据更新/01核心/201212";
            //环境配置
            realSubmitor.CodeRootPathVss = @"$/AB-G-devlis";
            //环境配置
            realSubmitor.CodeRootPathLocal = @"D:\Work\Dev\Workspace\AB-G-devlis";
            //输入
            realSubmitor.RecordLocalPath = @"D:\Work\Task\test更新列表.xls";
            //环境配置
            realSubmitor.RecordTempRoot = @"D:\Temp\vss更新";
            //环境配置
            realSubmitor.RecordVssRoot = @"$/B-更新目录/01-应用更新";

            //创建一个任务提交代理
            ISubmitVss submitProxy = new SubmitVssProxy(realSubmitor);
            //使用代理提交任务
            submitProxy.Submit();

        }

        public int SubmitDevDoc()
        {
            SubmitVssTemplate realSubmitor = new SubmitVssConcrete();
            //输入
            realSubmitor.DesignDocLocalPath = @"D:\Work\Task\已经上线\ABLREQUEST-1083-银保通签发保单之后发送承保短信\ddd.doc";
            //输入
            realSubmitor.TestDocLocalPath = @"D:\Work\Task\ABLREQUEST-1396-团险添加投保率不足0.75的控制提示\ABLREQUEST-1396-团险添加投保率不足0.75的控制提示-自测试报告20121204.doc";
            //输入
            realSubmitor.DocVssFolder = @"$/LIS－CM－AB/05-项目任务/B-契约模块/ABLREQUEST-1396-团险添加投保率不足0.75的控制提示";
            return 0;
        }
    }
}
