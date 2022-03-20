from time import sleep
from domain.boia import Boia
from domain.relogio import Relogio
from screen import Screen
import keyboard


boia = Boia()
relogio = Relogio()
while True:
    Screen.getScreenshot(relogio, False)
    Screen.getScreenshot(boia, False)   
    sleep(.23) 
    if keyboard.is_pressed('q'):
        break
