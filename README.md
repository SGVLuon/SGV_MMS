# SGV_MMS
Meal Management System in SGVQV

Termianl : wiseeyeon

Process deploy data : Wiseyeon > Access > Mssql
  Wiseeye -May cham cong tab > select date > Tat ca cac may > Duyet tu may cham cong
  When click search button in client auto deploy data from access to mssql
  
Access 
  pw : 12112009
  query - to mssql : 
  INSERT INTO dbo_Checkinout
  SELECT src.*
  FROM checkinout AS src LEFT JOIN dbo_Checkinout AS tgt ON (src.timestr = tgt.timestr) AND (src.userenrollnumber = tgt.userenrollnumber)
  WHERE tgt.timestr IS NULL;

