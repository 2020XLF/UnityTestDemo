# coding:utf-8

import os, sys
import datetime
import time

#Program File ====> progra~1
# 设置你本地的Unity安装目录
unity_exe = r'C:\progra~1\Unity\2018_4_19\Editor\Unity.exe'
# unity_exe ='unity'

func_path = r'Cshape.TestFunc'
# unity工程目录，当前脚本放在unity工程根目录中
project_path = r'E:/myGitProject/UnityTestDemo/UguiFirstUse/UGUIFirstUse'
# 日志
log_file = os.getcwd() + '/unity_log.log'



# 调用bake静态方法
def call_unity_bake_func(func):
    print('call_unity_bake_func: ' + func_path)
    #cmdInfo = "start "+unity_exe + ' -quit ' + ' -batchmode ' + ' -projectPath ' + project_path + ' -logFile ' + log_file + ' -executeMethod ' + func_path
    data = r'start {0} -quit  -batchmode  -projectPath {1} -logFile {2}  -executeMethod {3}'.format(unity_exe,project_path,log_file,func_path)
    print(data)
    os.system(data)

def main():
    call_unity_bake_func(func_path)
    #s = r'C:\progra~1\Unity\2018_4_19'

    #os.chdir(s)
    #print(os.listdir())
    #os.system(r'cd C:\"Program Files";cd Unity\2018_4_19')


if __name__ == '__main__':
    main()

