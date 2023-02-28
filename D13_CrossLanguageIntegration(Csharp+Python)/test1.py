'''
印出參數有幾個：print(len(sys.argv))
印出檔案名稱：print(sys.argv[0])，也就是執行的 Python 本身檔案名稱
印出第一個參數：print(sys.argv[1])
印出第二個參數：print(sys.argv[2])
印出所有參數：print(sys.argv)，也就是印出 sys.argv list

python     test.py      argv1       argv2
'''

import sys

if len(sys.argv) == 1:
    print('no argument',flush=True)
pass

print(f"sys.argv[0] : {sys.argv[0]}",flush=True)
print(f"sys.argv[1] : {sys.argv[1]}",flush=True)
print(f"sys.argv[2] : {sys.argv[2]}",flush=True)
