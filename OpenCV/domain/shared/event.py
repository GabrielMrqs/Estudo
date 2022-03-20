from abc import ABC, abstractmethod, abstractproperty


class Event(ABC):
    @abstractmethod
    def doAction(self, max_val):
        pass

    @property
    @abstractmethod
    def location(self):
        pass

    @property
    @abstractmethod
    def image(self):
        pass
