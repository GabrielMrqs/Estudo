from time import sleep
import cv2
from cv2 import IMREAD_UNCHANGED
from domain.shared.event import Event
import pyautogui


class Boia(Event):
    boia_location = {
        'left': 1250,
        'top': 800,
        'width': 250,
        'height': 150
    }

    def doAction(self, max_val):
        x = 1600 if max_val > .85 else 500
        pyautogui.click(x=x, y=850)

    @property
    def location(self):
        return self.boia_location

    @property
    def image(self):
        return cv2.imread('images\\boia.jpg', IMREAD_UNCHANGED)
