from datetime import datetime

import jinja2
import pdfkit
import requests

goal_a1 = requests.get("http://localhost:5501/gesamttubenanzZiel/4Machines").json()
goal_a2 = goal_a1
goal_a3 = goal_a1
goal_a4 = goal_a1
global_goal = goal_a1 * 4

error_a1 = requests.get("http://localhost:5501/kaputteTubenAnz/TAA1").json()
error_a2 = requests.get("http://localhost:5501/kaputteTubenAnz/TAA2").json()
error_a3 = requests.get("http://localhost:5501/kaputteTubenAnz/TAA3").json()
error_a4 = requests.get("http://localhost:5501/kaputteTubenAnz/TAA4").json()
global_error = error_a1 + error_a2 + error_a3 + error_a4

amount_a1 = requests.get("http://localhost:5501/gesamttubenAnz/Machine1/1").json()
amount_a2 = requests.get("http://localhost:5501/gesamttubenAnz/Machine1/2").json()
amount_a3 = requests.get("http://localhost:5501/gesamttubenAnz/Machine2/1").json()
amount_a4 = requests.get("http://localhost:5501/gesamttubenAnz/Machine2/2").json()
global_amount = amount_a1 + amount_a2 + amount_a3 + amount_a4 - global_error

# calculate the percentage of the goal max 2 decimals
global_percent = round((global_amount / global_goal) * 100, 2)

# date and time as of now
create_date = datetime.now().strftime("%d.%m.%Y, %H:%M:%S")

final_a1 = amount_a1 - error_a1
final_a2 = amount_a2 - error_a2
final_a3 = amount_a3 - error_a3
final_a4 = amount_a4 - error_a4

# max 2 decimals
global_error_percent = round((global_error / global_amount) * 100, 2)
global_missing = global_goal - global_amount
global_missing_percent = round((global_missing / global_goal) * 100, 2)

contex = {"goal_a1": goal_a1, "goal_a2": goal_a2, "goal_a3": goal_a3, "goal_a4": goal_a4,
          "amount_a1": amount_a1, "amount_a2": amount_a2, "amount_a3": amount_a3, "amount_a4": amount_a4,
          "global_amount": global_amount, "global_goal": global_goal,
          "global_percent": global_percent, "create_date": create_date,
          "error_a1": error_a1, "error_a2": error_a2, "error_a3": error_a3, "error_a4": error_a4,
          "final_a1": final_a1, "final_a2": final_a2, "final_a3": final_a3, "final_a4": final_a4,
          "global_error": global_error, "global_error_percent": global_error_percent, "global_missing": global_missing,
          "global_missing_percent": global_missing_percent}

template_loader = jinja2.FileSystemLoader("./")
template_env = jinja2.Environment(loader=template_loader)

template = template_env.get_template("basic_template.html")
output_text = template.render(contex)

# "which wkhtmltopdf" in console to get the path to wkhtmltopdf (Mac only)
# on windows download and execute: https://wkhtmltopdf.org/downloads.html
# for Mac first install wkhtmltopdf via brew, see google page
# path on Mac: "/usr/local/bin/wkhtmltopdf"
# path on Windows: "C:/Program Files/wkhtmltopdf/bin/wkhtmltopdf.exe"


config = pdfkit.configuration(wkhtmltopdf="C:/Program Files/wkhtmltopdf/bin/wkhtmltopdf.exe")

pdfkit.from_string(output_text, "output.pdf", configuration=config, css="styles.css")
