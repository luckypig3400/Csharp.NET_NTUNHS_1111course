import sys
import time
if len(sys.argv) == 1:
    print('no argument',flush=True)
pass

print(f"sys.argv[0] : {sys.argv[0]}",flush=True)
print(f"sys.argv[1] : {sys.argv[1]}",flush=True)
print(f"sys.argv[2] : {sys.argv[2]}",flush=True)

i=0
while True:
  time.sleep(1)
  print(f"gogogo {i}")
  i=i+1
pass
