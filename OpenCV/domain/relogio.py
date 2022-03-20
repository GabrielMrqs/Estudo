import cv2
from cv2 import IMREAD_UNCHANGED
from domain.shared.event import Event
import pyautogui
from time import sleep

class Relogio(Event):
    relogio_location = {
        'left': 950,
        'top': 700,
        'width': 250,
        'height': 100
    }

    def doAction(self, max_val):
        if max_val > .85:
            x = 500
            pyautogui.click(x=x, y=850)

    @property
    def location(self):
        return self.relogio_location

    @property
    def image(self):
        return cv2.imread('images\\relogio.jpg', IMREAD_UNCHANGED)
