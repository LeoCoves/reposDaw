##Dates

from datetime import datetime 

now = datetime.now()

print(now.year)
print(now.month)
print(now.day)

timestamp = now.timestamp()
print(timestamp)
 

year_2023 = datetime(2023,1,1)

print(year_2023)


from datetime import time

currentTime = time(23, 1, 2)

print(currentTime)

from datetime import date

currentDateHoy = date.today()

print(currentDateHoy)

currentDate = date(2023, 1, 2)

print(currentDate)
print(currentDate.year)
print(currentDate.month)
print(currentDate.day)

diff = year_2023 - now

print(diff)


from datetime import timedelta

inittime_delta = timedelta(200, 100, 100, weeks=4)
endtime_delta = timedelta(200, 100, 100, weeks=1)

print(inittime_delta)
print(endtime_delta)
print(inittime_delta - endtime_delta)