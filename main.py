import os
import sys
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time


def open_air_console():
    chrome_options = Options()
    chrome_options.add_experimental_option("detach", True)
    driver = webdriver.Chrome(options=chrome_options)
    driver.get('https://www.airconsole.com')
    time.sleep(2)
    python_button = driver.find_element_by_xpath('//*[@id="homepage"]/a[1]').click()


if __name__ == '__main__':
    open_air_console()
