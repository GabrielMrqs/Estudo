import cv2
import numpy
import mss
from domain.shared.event import Event


sct = mss.mss()


class Screen:

    @staticmethod
    def getScreenshot(object: Event, visible):

        img = numpy.array(sct.grab(object.location))
        img = img[..., :3]

        result_img = cv2.matchTemplate(img, object.image, cv2.TM_CCOEFF_NORMED)

        _, max_val, _, max_loc = cv2.minMaxLoc(result_img)

        object.doAction(max_val)

        if visible:
            template_w = object.image.shape[1]
            template_h = object.image.shape[0]

            img = img.copy()

            cv2.rectangle(
                img, max_loc, (max_loc[0] + template_w, max_loc[1] + template_h), (0, 255, 255), 2)
            cv2.imshow('Screen Shot', img)
            cv2.waitKey(1)
