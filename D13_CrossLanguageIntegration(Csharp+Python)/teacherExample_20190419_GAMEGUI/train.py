import numpy as np  # math
import random  # random
import sqlite3
import sys
import os 
import time

CURR_FILE_DIR_PATH = os.path.dirname(os.path.realpath(__file__))
sql_multiple_insert=list()


def trainAI():
  
  t = 0

  random_low=random.uniform(1, 4)

  logtool=LOGTOOL()
  logtool.init()

  while(1):
    
    t = t + 1
    reward_t= random_low + random.uniform(1, 6)

    # store data into sql
    if t%logtool.SQL_NUM_LOG_TO_STORE==0:
      # for sql
      logtool.store_db_batch(sql_multiple_insert)
      sql_multiple_insert.clear()
    pass
    

    # for sql
    sim_wait_time=random.random()/100.0
    time.sleep(sim_wait_time)
    sql_multiple_insert.append([t,reward_t])
    print("{0}, {1}, {2}".format(sim_wait_time, t,reward_t), flush=True)

  pass
pass


#store sqlite
class LOGTOOL():

  def __init__ (self):

    #for log
    _logname=""
    _logpath=""

    if len(sys.argv) == 1:
      _logname="case1_log"
      _logpath=CURR_FILE_DIR_PATH
    elif len(sys.argv) == 2:
      _logname=sys.argv[1]
      _logpath=CURR_FILE_DIR_PATH
    elif len(sys.argv) == 3:
      _logname=sys.argv[1]
      _logpath=sys.argv[2]
    pass


    self.log_path=_logpath
    self.log_name=_logname
  pass
 
  def init(self):
    self.init_db()
  pass

  
  def init_db(self):

    self.SQL_NUM_LOG_TO_STORE=10
    self.SQL_FILE=self.log_path+"\\"+self.log_name+".db"
    print(self.SQL_FILE)
    #if os.path.exists(self.SQL_FILE):
    #  os.remove(self.SQL_FILE)
    #pass
    self.table="log"
    self.sql_conn = sqlite3.connect(self.SQL_FILE, timeout=10)
    self.sql_conn.execute('drop table IF EXISTS '+ self.table +' ;')
    self.sql_conn.execute('CREATE TABLE  IF NOT EXISTS '+ self.table +' (     "seq"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,     "timestamp"	INTEGER,     "reward"	INTEGER     );')
    self.sql_cursor = self.sql_conn.cursor()

  pass

  
  def store_db_batch(self, i_sql_multiple_insert):

    self.sql_conn.executemany('INSERT INTO '+self.table+' (timestamp,reward) VALUES (?, ?)', i_sql_multiple_insert)
    self.sql_conn.commit()

  pass
pass


def main():
  trainAI()
pass

if __name__ == "__main__":
  main()
pass

