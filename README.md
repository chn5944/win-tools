# win-tools

## Language

- [English](#english)
- [中文](#中文)

---

### English

#### Introduce

A collection of Windows system tools developed based on C #. net framework

#### Instructions for use
##### 1.TraverseFiles
###### Main function: Traverse all files under the specified folder and output them to a text box.

###### Parameters: The program contains two optional parameters, "include subfolders" and "do not output full path".

1) Checking "Include Subfolders" will output files under all sub folders. Each level of directory will be incremented by two blank lines to distinguish them, and the output sub folder suffix will be added with a colon

2) Checking "Do not output full path" will only output the file name without a path.

---

### 中文

#### 介绍

基于.net framework开发的windows系统小工具合集

#### 使用说明
##### 1.TraverseFiles
###### 主要功能：遍历指定文件夹下所有文件并输出到文本框中。
###### 参数：程序包含两个可选参数,"包含子文件夹"和"不输出全路径"。
1) 勾选"包含子文件夹"会输出所有子文件夹下文件，每级目录会递增两个空行用以区分，输出的子文件夹后缀会加冒号
2) 勾选"不输出全路径"会只输出文件名，不带有路径。
###### 示例
![](/pic/traverse_file_e.g._1_cn.png)
![](/pic/traverse_file_e.g._2_cn.png)
![](/pic/traverse_file_e.g._3_cn.png)
![](/pic/traverse_file_e.g._4_cn.png)


##### 2.BatchGenerateCode
###### 主要功能：批量生成固定格式代码。
###### 参数：程序包含一个可选参数,"NewLineForLoop"。以及递增数值的起止区间配置。
1) 勾选"NewLineForLoop"每行生成的代码会追加到新行。
2) 对应位置增加的数值应该用${}包裹, 需要做函数计算时变量用 x表示如 x-1;
###### 示例
![](/pic/batch_generate_code_e.g._1_cn.png)
![](/pic/batch_generate_code_e.g._2_cn.png)

##### 3.BatchRenameFiles
###### 主要功能：批量修改图像格式的文件名。主要适配安卓系统浏览图片时 存在(10、20、100)等名称时 100按名称排序在10后面 却在20前面的问题。文件名最大位数会根据文件总数自动计算。
###### 参数：程序包含一个可选参数,"包含子文件夹"。以及正则表达式选项。
1) 勾选"包含子文件夹"会遍历修改所有子文件夹下文件。
2) 使用正则表达式时需要对Regex匹配项的关键字做转义如匹配()之间的内容使用 \((.*)\)
3) 不使用正则时则使用替换全名
###### 示例
![](/pic/batch_rename_file_e.g._1_cn.png)
![](/pic/batch_rename_file_e.g._2_cn.png)
![](/pic/batch_rename_file_e.g._3_cn.png)