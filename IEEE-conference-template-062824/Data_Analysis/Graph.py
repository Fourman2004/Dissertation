import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sb


csv_data = pd.read_csv("data.csv")

def plotData():
    sb.set_style("darkgrid")
    sb.lineplot(x = csv_data["Actual Time"], y = csv_data["Time"])
    plt.show()



plotData()
    
