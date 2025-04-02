import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sb


csv_data = pd.read_csv("data.csv")

def plotData():
    sb.set_style("darkgrid")
    sb.regplot(x = csv_data["Hours of Sleep"], y = csv_data["Interview/Documented Time(minutes)"], data = csv_data, ci=None)
    plt.show()



plotData()
    
