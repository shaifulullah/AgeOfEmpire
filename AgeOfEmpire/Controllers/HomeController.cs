﻿using AgeOfEmpire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfEmpire.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(int armyid)
        {
            List<ArmyUnits> army = new List<ArmyUnits>();

            army.Add(new ArmyUnits { id = 1, name = "calavary1", hitpoints = 20, health = 25 ,armyid=1,imgsrc= "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M258.962%2029.14c-3.21.063-6.68%201.158-10.303%203.4-5.798%203.584-11.47%2010.14-14.872%2018.715-3.4%208.575-3.767%2017.236-2.004%2023.82%201.763%206.585%205.248%2010.765%209.83%2012.583%204.582%201.817%209.986%201.165%2015.784-2.42%205.797-3.586%2011.467-10.143%2014.87-18.717%203.4-8.573%203.767-17.235%202.005-23.82-1.763-6.584-5.25-10.764-9.832-12.58-1.718-.683-3.55-1.018-5.478-.98zm83.428%2036.012c-8.823%2013.437-17.545%2027.577-36.268%2045.2l-1.615%201.52-2.137.596c-9.165%202.554-19%203.7-28.863%204.48-.54%205.822-1.76%2011.47-3.492%2016.946%2014.814.187%2028.827-.778%2041.297-4.62%2018.26-17.188%2036.623-35.375%2044.685-56.7l-13.607-7.422zm-133.135%2031.58c-.172%200-.348.005-.527.02-1.248.117-2.846.825-5.022%202.126-11.898%2012.29-14.007%2033.196-.867%2057.082%205.73%2010.42%2018.094%2018.277%2033.66%2023.58%2013.165%204.485%2028.138%207.013%2041.808%208.51l3.71-13.443c-6.24-1.808-14.008-3.65-22.142-6.082-11.813-3.53-24.576-8.437-34.355-18.432l-.343-.35-.303-.388c-5.047-6.43-5.557-13.842-5.6-22.496-.037-7.045.813-15.254%202.02-24.023-3.345-2.203-6.258-4.21-8.39-5.088-1.395-.575-2.445-1.008-3.65-1.018zm29.242%2012.676c-.806%206.653-1.25%2012.573-1.226%2017.36.035%206.717%201.526%2010.814%201.69%2011.21%201.988%201.936%204.304%203.67%206.87%205.24%204.536-8.52%208.03-16.96%209.363-25.23l-16.696-8.58zm202.955%2036.5c-38.698.407-97.748%2025.527-127.31%2046.75l21.93%2026.664c23.08-25.157%2050.67-42.282%2078.29-49.248%2028.02-7.068%2056.45-3.25%2078.33%2013.597%201.784-1.8%202.504-3.56%202.694-5.432.305-3.01-.998-7.446-4.865-12.283-7.734-9.675-24.947-19.342-45.388-20.008-1.204-.04-2.43-.052-3.68-.04zm-259.16%208.734c-6.568%2016.39-10.208%2033.35-7.805%2047.883%202.263%2013.104%208.145%2017.46%2018.125%2021.94%209.99%204.483%2023.807%207.117%2036.907%2014.036l6.466%203.417-2.022%207.03c-5.67%2019.72-14.65%2038.776-28.312%2056.41%208.66%2010.85%2024.016%2019.95%2040.84%2029.016l6.138-10.893-17.434-29.078%204.14-4.914c10.787-12.804%2016.836-38.882%2020.882-55.754-7.692-7.7-25.79-16.08-42.803-28.55l-6.36-4.66%203.784-6.917c.52-.952%201.076-1.906%201.62-2.86-12.188-5.97-22.86-14.237-29.39-26.11-1.823-3.313-3.407-6.652-4.778-9.995zm260.135%2029.922c-7.587-.093-15.517.908-23.664%202.963-26.07%206.576-53.767%2024.346-75.986%2051.377l-6.952%208.457-33.34-40.54c-1.77.288-3.426.55-5.21.842%209.908%2016.11%2016.95%2031.17%2025.693%2040.888%205.715%206.352%2011.743%2010.584%2020.38%2012.742%208.025%202.006%2018.66%202.104%2033.263-1.126-2.695-7.855-2.26-16.004-.318-23.077%202.52-9.172%207.08-17.28%2010.78-24.534l16.035%208.184c-2.167%204.244-4.322%208.392-6.112%2012.324%205.102-.272%2013.1-.745%2020.61-1.246%208.984-.6%2014.34-.982%2017.38-1.197%201.703-3.57%203.562-6.718%205.905-9.497%203.513-4.17%208.686-7.383%2014.256-8.108%201.392-.18%202.764-.257%204.13-.234%206.8.114%2013.423%202.692%2021.293%206.686%201.867-6.108%203.71-12.142%205.54-18.045-12.05-11.18-27.044-16.652-43.683-16.856zM277.92%20210.86c-4.448.743-8.952%201.51-13.448%202.27%205.022%203.758%209.534%208.032%2013.05%2013.293l2.204%203.297-.948%203.852c-3.357%2013.658-7.853%2041.85-21.802%2062.15l16.474%2027.48-14.802%2026.26c6.94-1.8%2013.538-4.246%2019.607-7.447l11-5.8%202.074%2012.26c5.978%2035.36-13.102%2068.48-22.475%2099.294%206.508%209.05%2012.247%2014.98%2017.275%2020.388%204.097%204.407%208.004%209.006%2010.654%2014.683h28.254c-1.863-9.857-5.227-15.497-17.834-26.75l-5.578-4.98%203.87-6.396c15.287-25.248%2024.903-82.92%2028.925-111.46l.92-6.526%206.503-1.092c10.253-1.72%2016.833-5.857%2022.162-11.826%205.33-5.97%209.233-14.076%2012.258-23.29%201.334-4.067%202.448-8.31%203.478-12.62-16.163%203.494-29.45%203.68-40.754.855-12.36-3.088-21.957-9.893-29.4-18.164-12.948-14.39-20.65-32.733-31.665-49.73zm-108.337%2019.524c-14.047%202.79-27.408%205.57-39.43%208.29-12.594%204.275-20.655%2010.807-26.92%2019.765-6.32%209.03-10.644%2020.798-14.083%2034.75-6.85%2027.778-10.026%2063.737-23.073%20100.858l-17.465%2065.434c3.948%203.74%207.722%206.273%2011.717%209.855%203.488%203.13%206.69%207.757%208.58%2013.504h23.447c.593-9.5-2.71-19.834-10.856-26.5l-5.18-4.235%2026.142-62.953%205.35-.537c21.24-2.133%2040.548-26.11%2051.19-40.262l3.75-4.982%205.982%201.758c22.6%206.637%2049.11%2010.156%2073.326%207.377-21.107-11.086-43.545-22.54-55.405-43.017l-3.175-5.483%204.09-4.84c12.58-14.873%2020.877-30.868%2026.6-47.8-8.712-3.39-18.953-6.002-28.93-10.48-5.508-2.472-10.967-5.897-15.657-10.5zm288.38.46c-.19-.005-.353.002-.493.02-1.118.146-1.406.185-2.817%201.858-1.352%201.604-3.214%204.944-5.216%209.785-1.614%205.982-.063%2010.297%204.242%2015.903%202.565%203.34%206.158%206.746%2010.16%2010.117%204.106-10.06%207.79-20.716%2011.25-31.467-9.026-4.414-14.86-6.17-17.128-6.217zm-340.25%2013.26c-.02%200-.32.076-.358.08.37.02.43-.086.36-.08zm313.353%204.83c-4.126.288-5.917.422-12.262.845-10.82.72-21.303%201.44-26.12%201.497.313%202.1%201.08%204.127%202.41%206.265l.532.854.33.95c.627%201.807%201.2%203.502%201.744%205.15%202.49%204.435%209.938%2011.22%2020.264%2016.535%2010.333%205.317%2023.014%209.548%2034.29%2011.682%201.334-2.325%202.624-4.727%203.876-7.19-5.863-4.615-11.877-9.832-16.727-16.148-4.34-5.652-7.67-12.72-8.337-20.44zm-347.57%207.306c-5.687%202.507-11.285%205.163-16.114%207.74-6.134%203.273-10.633%206.54-12.37%208.03-4.556%2015.79-6.52%2030.088-11.78%2044.884-4.72%2013.276-12.487%2026.58-26.66%2040.11%2011.624%2010%2023.234%2016.21%2037.47%2015.316%208.202-29.22%2011.38-58.08%2017.63-83.44%202.888-11.71%206.472-22.743%2011.825-32.64zm320.41%2037.61c.224%205.742-.135%2011.87-.944%2019.608-.05%206.863%203.644%2011.33%209.248%2012.71%205.623%201.388%2014.58-.295%2024.822-12.622l.204-.244.22-.23c1.315-1.372%202.59-2.824%203.836-4.324-10.776-2.654-21.76-6.668-31.562-11.71-1.99-1.025-3.925-2.093-5.825-3.19zm-27.463%2033.017c-6.36%206.718-14.816%2011.936-25.082%2014.857-.01.077-.026.17-.037.248l15.336%2017.203-8.665%2025.655-14.53%203.216c-1.706%208.07-3.678%2016.264-5.95%2024.278.423.08.85.17%201.27.246%2010.442%201.892%2019.172%201.915%2026.915-1.684%2017.515-18.86%2028.118-31.565%2031.95-53.44-1.87-7.903-10.127-20.008-19.666-29.138-.512-.49-1.026-.967-1.54-1.44zm-210.993%2042.66c-5.333%206.792-12.013%2014.51-20.16%2021.164%2016.307%2031.444%2034.568%2062.892%2057.48%2092.173h26.753c-28.96-35.58-47.84-75.123-64.073-113.336z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 2, name = "calavary2", hitpoints = 15, health = 25, armyid = 1, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M258.962%2029.14c-3.21.063-6.68%201.158-10.303%203.4-5.798%203.584-11.47%2010.14-14.872%2018.715-3.4%208.575-3.767%2017.236-2.004%2023.82%201.763%206.585%205.248%2010.765%209.83%2012.583%204.582%201.817%209.986%201.165%2015.784-2.42%205.797-3.586%2011.467-10.143%2014.87-18.717%203.4-8.573%203.767-17.235%202.005-23.82-1.763-6.584-5.25-10.764-9.832-12.58-1.718-.683-3.55-1.018-5.478-.98zm83.428%2036.012c-8.823%2013.437-17.545%2027.577-36.268%2045.2l-1.615%201.52-2.137.596c-9.165%202.554-19%203.7-28.863%204.48-.54%205.822-1.76%2011.47-3.492%2016.946%2014.814.187%2028.827-.778%2041.297-4.62%2018.26-17.188%2036.623-35.375%2044.685-56.7l-13.607-7.422zm-133.135%2031.58c-.172%200-.348.005-.527.02-1.248.117-2.846.825-5.022%202.126-11.898%2012.29-14.007%2033.196-.867%2057.082%205.73%2010.42%2018.094%2018.277%2033.66%2023.58%2013.165%204.485%2028.138%207.013%2041.808%208.51l3.71-13.443c-6.24-1.808-14.008-3.65-22.142-6.082-11.813-3.53-24.576-8.437-34.355-18.432l-.343-.35-.303-.388c-5.047-6.43-5.557-13.842-5.6-22.496-.037-7.045.813-15.254%202.02-24.023-3.345-2.203-6.258-4.21-8.39-5.088-1.395-.575-2.445-1.008-3.65-1.018zm29.242%2012.676c-.806%206.653-1.25%2012.573-1.226%2017.36.035%206.717%201.526%2010.814%201.69%2011.21%201.988%201.936%204.304%203.67%206.87%205.24%204.536-8.52%208.03-16.96%209.363-25.23l-16.696-8.58zm202.955%2036.5c-38.698.407-97.748%2025.527-127.31%2046.75l21.93%2026.664c23.08-25.157%2050.67-42.282%2078.29-49.248%2028.02-7.068%2056.45-3.25%2078.33%2013.597%201.784-1.8%202.504-3.56%202.694-5.432.305-3.01-.998-7.446-4.865-12.283-7.734-9.675-24.947-19.342-45.388-20.008-1.204-.04-2.43-.052-3.68-.04zm-259.16%208.734c-6.568%2016.39-10.208%2033.35-7.805%2047.883%202.263%2013.104%208.145%2017.46%2018.125%2021.94%209.99%204.483%2023.807%207.117%2036.907%2014.036l6.466%203.417-2.022%207.03c-5.67%2019.72-14.65%2038.776-28.312%2056.41%208.66%2010.85%2024.016%2019.95%2040.84%2029.016l6.138-10.893-17.434-29.078%204.14-4.914c10.787-12.804%2016.836-38.882%2020.882-55.754-7.692-7.7-25.79-16.08-42.803-28.55l-6.36-4.66%203.784-6.917c.52-.952%201.076-1.906%201.62-2.86-12.188-5.97-22.86-14.237-29.39-26.11-1.823-3.313-3.407-6.652-4.778-9.995zm260.135%2029.922c-7.587-.093-15.517.908-23.664%202.963-26.07%206.576-53.767%2024.346-75.986%2051.377l-6.952%208.457-33.34-40.54c-1.77.288-3.426.55-5.21.842%209.908%2016.11%2016.95%2031.17%2025.693%2040.888%205.715%206.352%2011.743%2010.584%2020.38%2012.742%208.025%202.006%2018.66%202.104%2033.263-1.126-2.695-7.855-2.26-16.004-.318-23.077%202.52-9.172%207.08-17.28%2010.78-24.534l16.035%208.184c-2.167%204.244-4.322%208.392-6.112%2012.324%205.102-.272%2013.1-.745%2020.61-1.246%208.984-.6%2014.34-.982%2017.38-1.197%201.703-3.57%203.562-6.718%205.905-9.497%203.513-4.17%208.686-7.383%2014.256-8.108%201.392-.18%202.764-.257%204.13-.234%206.8.114%2013.423%202.692%2021.293%206.686%201.867-6.108%203.71-12.142%205.54-18.045-12.05-11.18-27.044-16.652-43.683-16.856zM277.92%20210.86c-4.448.743-8.952%201.51-13.448%202.27%205.022%203.758%209.534%208.032%2013.05%2013.293l2.204%203.297-.948%203.852c-3.357%2013.658-7.853%2041.85-21.802%2062.15l16.474%2027.48-14.802%2026.26c6.94-1.8%2013.538-4.246%2019.607-7.447l11-5.8%202.074%2012.26c5.978%2035.36-13.102%2068.48-22.475%2099.294%206.508%209.05%2012.247%2014.98%2017.275%2020.388%204.097%204.407%208.004%209.006%2010.654%2014.683h28.254c-1.863-9.857-5.227-15.497-17.834-26.75l-5.578-4.98%203.87-6.396c15.287-25.248%2024.903-82.92%2028.925-111.46l.92-6.526%206.503-1.092c10.253-1.72%2016.833-5.857%2022.162-11.826%205.33-5.97%209.233-14.076%2012.258-23.29%201.334-4.067%202.448-8.31%203.478-12.62-16.163%203.494-29.45%203.68-40.754.855-12.36-3.088-21.957-9.893-29.4-18.164-12.948-14.39-20.65-32.733-31.665-49.73zm-108.337%2019.524c-14.047%202.79-27.408%205.57-39.43%208.29-12.594%204.275-20.655%2010.807-26.92%2019.765-6.32%209.03-10.644%2020.798-14.083%2034.75-6.85%2027.778-10.026%2063.737-23.073%20100.858l-17.465%2065.434c3.948%203.74%207.722%206.273%2011.717%209.855%203.488%203.13%206.69%207.757%208.58%2013.504h23.447c.593-9.5-2.71-19.834-10.856-26.5l-5.18-4.235%2026.142-62.953%205.35-.537c21.24-2.133%2040.548-26.11%2051.19-40.262l3.75-4.982%205.982%201.758c22.6%206.637%2049.11%2010.156%2073.326%207.377-21.107-11.086-43.545-22.54-55.405-43.017l-3.175-5.483%204.09-4.84c12.58-14.873%2020.877-30.868%2026.6-47.8-8.712-3.39-18.953-6.002-28.93-10.48-5.508-2.472-10.967-5.897-15.657-10.5zm288.38.46c-.19-.005-.353.002-.493.02-1.118.146-1.406.185-2.817%201.858-1.352%201.604-3.214%204.944-5.216%209.785-1.614%205.982-.063%2010.297%204.242%2015.903%202.565%203.34%206.158%206.746%2010.16%2010.117%204.106-10.06%207.79-20.716%2011.25-31.467-9.026-4.414-14.86-6.17-17.128-6.217zm-340.25%2013.26c-.02%200-.32.076-.358.08.37.02.43-.086.36-.08zm313.353%204.83c-4.126.288-5.917.422-12.262.845-10.82.72-21.303%201.44-26.12%201.497.313%202.1%201.08%204.127%202.41%206.265l.532.854.33.95c.627%201.807%201.2%203.502%201.744%205.15%202.49%204.435%209.938%2011.22%2020.264%2016.535%2010.333%205.317%2023.014%209.548%2034.29%2011.682%201.334-2.325%202.624-4.727%203.876-7.19-5.863-4.615-11.877-9.832-16.727-16.148-4.34-5.652-7.67-12.72-8.337-20.44zm-347.57%207.306c-5.687%202.507-11.285%205.163-16.114%207.74-6.134%203.273-10.633%206.54-12.37%208.03-4.556%2015.79-6.52%2030.088-11.78%2044.884-4.72%2013.276-12.487%2026.58-26.66%2040.11%2011.624%2010%2023.234%2016.21%2037.47%2015.316%208.202-29.22%2011.38-58.08%2017.63-83.44%202.888-11.71%206.472-22.743%2011.825-32.64zm320.41%2037.61c.224%205.742-.135%2011.87-.944%2019.608-.05%206.863%203.644%2011.33%209.248%2012.71%205.623%201.388%2014.58-.295%2024.822-12.622l.204-.244.22-.23c1.315-1.372%202.59-2.824%203.836-4.324-10.776-2.654-21.76-6.668-31.562-11.71-1.99-1.025-3.925-2.093-5.825-3.19zm-27.463%2033.017c-6.36%206.718-14.816%2011.936-25.082%2014.857-.01.077-.026.17-.037.248l15.336%2017.203-8.665%2025.655-14.53%203.216c-1.706%208.07-3.678%2016.264-5.95%2024.278.423.08.85.17%201.27.246%2010.442%201.892%2019.172%201.915%2026.915-1.684%2017.515-18.86%2028.118-31.565%2031.95-53.44-1.87-7.903-10.127-20.008-19.666-29.138-.512-.49-1.026-.967-1.54-1.44zm-210.993%2042.66c-5.333%206.792-12.013%2014.51-20.16%2021.164%2016.307%2031.444%2034.568%2062.892%2057.48%2092.173h26.753c-28.96-35.58-47.84-75.123-64.073-113.336z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 3, name = "calavary3", hitpoints = 10, health = 25 , armyid = 1, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M258.962%2029.14c-3.21.063-6.68%201.158-10.303%203.4-5.798%203.584-11.47%2010.14-14.872%2018.715-3.4%208.575-3.767%2017.236-2.004%2023.82%201.763%206.585%205.248%2010.765%209.83%2012.583%204.582%201.817%209.986%201.165%2015.784-2.42%205.797-3.586%2011.467-10.143%2014.87-18.717%203.4-8.573%203.767-17.235%202.005-23.82-1.763-6.584-5.25-10.764-9.832-12.58-1.718-.683-3.55-1.018-5.478-.98zm83.428%2036.012c-8.823%2013.437-17.545%2027.577-36.268%2045.2l-1.615%201.52-2.137.596c-9.165%202.554-19%203.7-28.863%204.48-.54%205.822-1.76%2011.47-3.492%2016.946%2014.814.187%2028.827-.778%2041.297-4.62%2018.26-17.188%2036.623-35.375%2044.685-56.7l-13.607-7.422zm-133.135%2031.58c-.172%200-.348.005-.527.02-1.248.117-2.846.825-5.022%202.126-11.898%2012.29-14.007%2033.196-.867%2057.082%205.73%2010.42%2018.094%2018.277%2033.66%2023.58%2013.165%204.485%2028.138%207.013%2041.808%208.51l3.71-13.443c-6.24-1.808-14.008-3.65-22.142-6.082-11.813-3.53-24.576-8.437-34.355-18.432l-.343-.35-.303-.388c-5.047-6.43-5.557-13.842-5.6-22.496-.037-7.045.813-15.254%202.02-24.023-3.345-2.203-6.258-4.21-8.39-5.088-1.395-.575-2.445-1.008-3.65-1.018zm29.242%2012.676c-.806%206.653-1.25%2012.573-1.226%2017.36.035%206.717%201.526%2010.814%201.69%2011.21%201.988%201.936%204.304%203.67%206.87%205.24%204.536-8.52%208.03-16.96%209.363-25.23l-16.696-8.58zm202.955%2036.5c-38.698.407-97.748%2025.527-127.31%2046.75l21.93%2026.664c23.08-25.157%2050.67-42.282%2078.29-49.248%2028.02-7.068%2056.45-3.25%2078.33%2013.597%201.784-1.8%202.504-3.56%202.694-5.432.305-3.01-.998-7.446-4.865-12.283-7.734-9.675-24.947-19.342-45.388-20.008-1.204-.04-2.43-.052-3.68-.04zm-259.16%208.734c-6.568%2016.39-10.208%2033.35-7.805%2047.883%202.263%2013.104%208.145%2017.46%2018.125%2021.94%209.99%204.483%2023.807%207.117%2036.907%2014.036l6.466%203.417-2.022%207.03c-5.67%2019.72-14.65%2038.776-28.312%2056.41%208.66%2010.85%2024.016%2019.95%2040.84%2029.016l6.138-10.893-17.434-29.078%204.14-4.914c10.787-12.804%2016.836-38.882%2020.882-55.754-7.692-7.7-25.79-16.08-42.803-28.55l-6.36-4.66%203.784-6.917c.52-.952%201.076-1.906%201.62-2.86-12.188-5.97-22.86-14.237-29.39-26.11-1.823-3.313-3.407-6.652-4.778-9.995zm260.135%2029.922c-7.587-.093-15.517.908-23.664%202.963-26.07%206.576-53.767%2024.346-75.986%2051.377l-6.952%208.457-33.34-40.54c-1.77.288-3.426.55-5.21.842%209.908%2016.11%2016.95%2031.17%2025.693%2040.888%205.715%206.352%2011.743%2010.584%2020.38%2012.742%208.025%202.006%2018.66%202.104%2033.263-1.126-2.695-7.855-2.26-16.004-.318-23.077%202.52-9.172%207.08-17.28%2010.78-24.534l16.035%208.184c-2.167%204.244-4.322%208.392-6.112%2012.324%205.102-.272%2013.1-.745%2020.61-1.246%208.984-.6%2014.34-.982%2017.38-1.197%201.703-3.57%203.562-6.718%205.905-9.497%203.513-4.17%208.686-7.383%2014.256-8.108%201.392-.18%202.764-.257%204.13-.234%206.8.114%2013.423%202.692%2021.293%206.686%201.867-6.108%203.71-12.142%205.54-18.045-12.05-11.18-27.044-16.652-43.683-16.856zM277.92%20210.86c-4.448.743-8.952%201.51-13.448%202.27%205.022%203.758%209.534%208.032%2013.05%2013.293l2.204%203.297-.948%203.852c-3.357%2013.658-7.853%2041.85-21.802%2062.15l16.474%2027.48-14.802%2026.26c6.94-1.8%2013.538-4.246%2019.607-7.447l11-5.8%202.074%2012.26c5.978%2035.36-13.102%2068.48-22.475%2099.294%206.508%209.05%2012.247%2014.98%2017.275%2020.388%204.097%204.407%208.004%209.006%2010.654%2014.683h28.254c-1.863-9.857-5.227-15.497-17.834-26.75l-5.578-4.98%203.87-6.396c15.287-25.248%2024.903-82.92%2028.925-111.46l.92-6.526%206.503-1.092c10.253-1.72%2016.833-5.857%2022.162-11.826%205.33-5.97%209.233-14.076%2012.258-23.29%201.334-4.067%202.448-8.31%203.478-12.62-16.163%203.494-29.45%203.68-40.754.855-12.36-3.088-21.957-9.893-29.4-18.164-12.948-14.39-20.65-32.733-31.665-49.73zm-108.337%2019.524c-14.047%202.79-27.408%205.57-39.43%208.29-12.594%204.275-20.655%2010.807-26.92%2019.765-6.32%209.03-10.644%2020.798-14.083%2034.75-6.85%2027.778-10.026%2063.737-23.073%20100.858l-17.465%2065.434c3.948%203.74%207.722%206.273%2011.717%209.855%203.488%203.13%206.69%207.757%208.58%2013.504h23.447c.593-9.5-2.71-19.834-10.856-26.5l-5.18-4.235%2026.142-62.953%205.35-.537c21.24-2.133%2040.548-26.11%2051.19-40.262l3.75-4.982%205.982%201.758c22.6%206.637%2049.11%2010.156%2073.326%207.377-21.107-11.086-43.545-22.54-55.405-43.017l-3.175-5.483%204.09-4.84c12.58-14.873%2020.877-30.868%2026.6-47.8-8.712-3.39-18.953-6.002-28.93-10.48-5.508-2.472-10.967-5.897-15.657-10.5zm288.38.46c-.19-.005-.353.002-.493.02-1.118.146-1.406.185-2.817%201.858-1.352%201.604-3.214%204.944-5.216%209.785-1.614%205.982-.063%2010.297%204.242%2015.903%202.565%203.34%206.158%206.746%2010.16%2010.117%204.106-10.06%207.79-20.716%2011.25-31.467-9.026-4.414-14.86-6.17-17.128-6.217zm-340.25%2013.26c-.02%200-.32.076-.358.08.37.02.43-.086.36-.08zm313.353%204.83c-4.126.288-5.917.422-12.262.845-10.82.72-21.303%201.44-26.12%201.497.313%202.1%201.08%204.127%202.41%206.265l.532.854.33.95c.627%201.807%201.2%203.502%201.744%205.15%202.49%204.435%209.938%2011.22%2020.264%2016.535%2010.333%205.317%2023.014%209.548%2034.29%2011.682%201.334-2.325%202.624-4.727%203.876-7.19-5.863-4.615-11.877-9.832-16.727-16.148-4.34-5.652-7.67-12.72-8.337-20.44zm-347.57%207.306c-5.687%202.507-11.285%205.163-16.114%207.74-6.134%203.273-10.633%206.54-12.37%208.03-4.556%2015.79-6.52%2030.088-11.78%2044.884-4.72%2013.276-12.487%2026.58-26.66%2040.11%2011.624%2010%2023.234%2016.21%2037.47%2015.316%208.202-29.22%2011.38-58.08%2017.63-83.44%202.888-11.71%206.472-22.743%2011.825-32.64zm320.41%2037.61c.224%205.742-.135%2011.87-.944%2019.608-.05%206.863%203.644%2011.33%209.248%2012.71%205.623%201.388%2014.58-.295%2024.822-12.622l.204-.244.22-.23c1.315-1.372%202.59-2.824%203.836-4.324-10.776-2.654-21.76-6.668-31.562-11.71-1.99-1.025-3.925-2.093-5.825-3.19zm-27.463%2033.017c-6.36%206.718-14.816%2011.936-25.082%2014.857-.01.077-.026.17-.037.248l15.336%2017.203-8.665%2025.655-14.53%203.216c-1.706%208.07-3.678%2016.264-5.95%2024.278.423.08.85.17%201.27.246%2010.442%201.892%2019.172%201.915%2026.915-1.684%2017.515-18.86%2028.118-31.565%2031.95-53.44-1.87-7.903-10.127-20.008-19.666-29.138-.512-.49-1.026-.967-1.54-1.44zm-210.993%2042.66c-5.333%206.792-12.013%2014.51-20.16%2021.164%2016.307%2031.444%2034.568%2062.892%2057.48%2092.173h26.753c-28.96-35.58-47.84-75.123-64.073-113.336z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 4, name = "calavary4", hitpoints = 30, health = 25 , armyid = 1, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M258.962%2029.14c-3.21.063-6.68%201.158-10.303%203.4-5.798%203.584-11.47%2010.14-14.872%2018.715-3.4%208.575-3.767%2017.236-2.004%2023.82%201.763%206.585%205.248%2010.765%209.83%2012.583%204.582%201.817%209.986%201.165%2015.784-2.42%205.797-3.586%2011.467-10.143%2014.87-18.717%203.4-8.573%203.767-17.235%202.005-23.82-1.763-6.584-5.25-10.764-9.832-12.58-1.718-.683-3.55-1.018-5.478-.98zm83.428%2036.012c-8.823%2013.437-17.545%2027.577-36.268%2045.2l-1.615%201.52-2.137.596c-9.165%202.554-19%203.7-28.863%204.48-.54%205.822-1.76%2011.47-3.492%2016.946%2014.814.187%2028.827-.778%2041.297-4.62%2018.26-17.188%2036.623-35.375%2044.685-56.7l-13.607-7.422zm-133.135%2031.58c-.172%200-.348.005-.527.02-1.248.117-2.846.825-5.022%202.126-11.898%2012.29-14.007%2033.196-.867%2057.082%205.73%2010.42%2018.094%2018.277%2033.66%2023.58%2013.165%204.485%2028.138%207.013%2041.808%208.51l3.71-13.443c-6.24-1.808-14.008-3.65-22.142-6.082-11.813-3.53-24.576-8.437-34.355-18.432l-.343-.35-.303-.388c-5.047-6.43-5.557-13.842-5.6-22.496-.037-7.045.813-15.254%202.02-24.023-3.345-2.203-6.258-4.21-8.39-5.088-1.395-.575-2.445-1.008-3.65-1.018zm29.242%2012.676c-.806%206.653-1.25%2012.573-1.226%2017.36.035%206.717%201.526%2010.814%201.69%2011.21%201.988%201.936%204.304%203.67%206.87%205.24%204.536-8.52%208.03-16.96%209.363-25.23l-16.696-8.58zm202.955%2036.5c-38.698.407-97.748%2025.527-127.31%2046.75l21.93%2026.664c23.08-25.157%2050.67-42.282%2078.29-49.248%2028.02-7.068%2056.45-3.25%2078.33%2013.597%201.784-1.8%202.504-3.56%202.694-5.432.305-3.01-.998-7.446-4.865-12.283-7.734-9.675-24.947-19.342-45.388-20.008-1.204-.04-2.43-.052-3.68-.04zm-259.16%208.734c-6.568%2016.39-10.208%2033.35-7.805%2047.883%202.263%2013.104%208.145%2017.46%2018.125%2021.94%209.99%204.483%2023.807%207.117%2036.907%2014.036l6.466%203.417-2.022%207.03c-5.67%2019.72-14.65%2038.776-28.312%2056.41%208.66%2010.85%2024.016%2019.95%2040.84%2029.016l6.138-10.893-17.434-29.078%204.14-4.914c10.787-12.804%2016.836-38.882%2020.882-55.754-7.692-7.7-25.79-16.08-42.803-28.55l-6.36-4.66%203.784-6.917c.52-.952%201.076-1.906%201.62-2.86-12.188-5.97-22.86-14.237-29.39-26.11-1.823-3.313-3.407-6.652-4.778-9.995zm260.135%2029.922c-7.587-.093-15.517.908-23.664%202.963-26.07%206.576-53.767%2024.346-75.986%2051.377l-6.952%208.457-33.34-40.54c-1.77.288-3.426.55-5.21.842%209.908%2016.11%2016.95%2031.17%2025.693%2040.888%205.715%206.352%2011.743%2010.584%2020.38%2012.742%208.025%202.006%2018.66%202.104%2033.263-1.126-2.695-7.855-2.26-16.004-.318-23.077%202.52-9.172%207.08-17.28%2010.78-24.534l16.035%208.184c-2.167%204.244-4.322%208.392-6.112%2012.324%205.102-.272%2013.1-.745%2020.61-1.246%208.984-.6%2014.34-.982%2017.38-1.197%201.703-3.57%203.562-6.718%205.905-9.497%203.513-4.17%208.686-7.383%2014.256-8.108%201.392-.18%202.764-.257%204.13-.234%206.8.114%2013.423%202.692%2021.293%206.686%201.867-6.108%203.71-12.142%205.54-18.045-12.05-11.18-27.044-16.652-43.683-16.856zM277.92%20210.86c-4.448.743-8.952%201.51-13.448%202.27%205.022%203.758%209.534%208.032%2013.05%2013.293l2.204%203.297-.948%203.852c-3.357%2013.658-7.853%2041.85-21.802%2062.15l16.474%2027.48-14.802%2026.26c6.94-1.8%2013.538-4.246%2019.607-7.447l11-5.8%202.074%2012.26c5.978%2035.36-13.102%2068.48-22.475%2099.294%206.508%209.05%2012.247%2014.98%2017.275%2020.388%204.097%204.407%208.004%209.006%2010.654%2014.683h28.254c-1.863-9.857-5.227-15.497-17.834-26.75l-5.578-4.98%203.87-6.396c15.287-25.248%2024.903-82.92%2028.925-111.46l.92-6.526%206.503-1.092c10.253-1.72%2016.833-5.857%2022.162-11.826%205.33-5.97%209.233-14.076%2012.258-23.29%201.334-4.067%202.448-8.31%203.478-12.62-16.163%203.494-29.45%203.68-40.754.855-12.36-3.088-21.957-9.893-29.4-18.164-12.948-14.39-20.65-32.733-31.665-49.73zm-108.337%2019.524c-14.047%202.79-27.408%205.57-39.43%208.29-12.594%204.275-20.655%2010.807-26.92%2019.765-6.32%209.03-10.644%2020.798-14.083%2034.75-6.85%2027.778-10.026%2063.737-23.073%20100.858l-17.465%2065.434c3.948%203.74%207.722%206.273%2011.717%209.855%203.488%203.13%206.69%207.757%208.58%2013.504h23.447c.593-9.5-2.71-19.834-10.856-26.5l-5.18-4.235%2026.142-62.953%205.35-.537c21.24-2.133%2040.548-26.11%2051.19-40.262l3.75-4.982%205.982%201.758c22.6%206.637%2049.11%2010.156%2073.326%207.377-21.107-11.086-43.545-22.54-55.405-43.017l-3.175-5.483%204.09-4.84c12.58-14.873%2020.877-30.868%2026.6-47.8-8.712-3.39-18.953-6.002-28.93-10.48-5.508-2.472-10.967-5.897-15.657-10.5zm288.38.46c-.19-.005-.353.002-.493.02-1.118.146-1.406.185-2.817%201.858-1.352%201.604-3.214%204.944-5.216%209.785-1.614%205.982-.063%2010.297%204.242%2015.903%202.565%203.34%206.158%206.746%2010.16%2010.117%204.106-10.06%207.79-20.716%2011.25-31.467-9.026-4.414-14.86-6.17-17.128-6.217zm-340.25%2013.26c-.02%200-.32.076-.358.08.37.02.43-.086.36-.08zm313.353%204.83c-4.126.288-5.917.422-12.262.845-10.82.72-21.303%201.44-26.12%201.497.313%202.1%201.08%204.127%202.41%206.265l.532.854.33.95c.627%201.807%201.2%203.502%201.744%205.15%202.49%204.435%209.938%2011.22%2020.264%2016.535%2010.333%205.317%2023.014%209.548%2034.29%2011.682%201.334-2.325%202.624-4.727%203.876-7.19-5.863-4.615-11.877-9.832-16.727-16.148-4.34-5.652-7.67-12.72-8.337-20.44zm-347.57%207.306c-5.687%202.507-11.285%205.163-16.114%207.74-6.134%203.273-10.633%206.54-12.37%208.03-4.556%2015.79-6.52%2030.088-11.78%2044.884-4.72%2013.276-12.487%2026.58-26.66%2040.11%2011.624%2010%2023.234%2016.21%2037.47%2015.316%208.202-29.22%2011.38-58.08%2017.63-83.44%202.888-11.71%206.472-22.743%2011.825-32.64zm320.41%2037.61c.224%205.742-.135%2011.87-.944%2019.608-.05%206.863%203.644%2011.33%209.248%2012.71%205.623%201.388%2014.58-.295%2024.822-12.622l.204-.244.22-.23c1.315-1.372%202.59-2.824%203.836-4.324-10.776-2.654-21.76-6.668-31.562-11.71-1.99-1.025-3.925-2.093-5.825-3.19zm-27.463%2033.017c-6.36%206.718-14.816%2011.936-25.082%2014.857-.01.077-.026.17-.037.248l15.336%2017.203-8.665%2025.655-14.53%203.216c-1.706%208.07-3.678%2016.264-5.95%2024.278.423.08.85.17%201.27.246%2010.442%201.892%2019.172%201.915%2026.915-1.684%2017.515-18.86%2028.118-31.565%2031.95-53.44-1.87-7.903-10.127-20.008-19.666-29.138-.512-.49-1.026-.967-1.54-1.44zm-210.993%2042.66c-5.333%206.792-12.013%2014.51-20.16%2021.164%2016.307%2031.444%2034.568%2062.892%2057.48%2092.173h26.753c-28.96-35.58-47.84-75.123-64.073-113.336z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 1, name = "infantry1", hitpoints = 30, health = 25 , armyid = 2,imgsrc= "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M159.1%2025.62l-3.5%2012.53%20134.9%2036.28%204.4-13.19zM316.4%2054.6l-8.6%2025.73c14.6%2013.43%2029.6%2014.58%2047.1%2013.07l6-29.18c-12.6-6.91-27.8-9.25-44.5-9.62zm128%2027.27l-29.6%208.09-4.7%2017.24%2023.8%2023%2052.1-11.7zm-68.5.58L373%2096.57l19.6%205.33%203.8-14.07zm-174.6%207.46c-7.3.18-14.4%203.61-20.7%209.95-7%207.24-12.4%2018.24-13.9%2031.04s1.4%2024.7%206.7%2033.3c5.4%208.4%2012.7%2013.5%2021.1%2014.4%208.4.8%2016.7-2.6%2023.8-9.9%207-7.2%2012.5-18.2%2014-31.1%201.4-12.7-1.5-24.6-6.8-33.1-5.4-8.55-12.7-13.61-21-14.47-1-.11-2.1-.15-3.2-.12zm113.3%2016.39c-4.6%2033.6-11.8%2060.1-22%2088.3l-27.5-3.6c-.4%2015-2.4%2030-7.5%2045.2%2020.6-.5%2040.2-2.8%2059.3-11.3%2011.3-37.8%2018.4-75.3%2024.3-112.9-8.9-.4-17.8-1.9-26.6-5.7zm-174.1%2076.9c-8.7%200-15.5.7-26.6%204.1-26.62%2016.2-45.72%2040.2-53%2057.9-8.4%2020.9-11.67%2047-11.26%2070.5l25.64%203.2c3.41-24%204.92-41.7%2010.83-60.8l47.29-34-2.9%2045.9%207.5-2.3c18-9.1%2030.5-20.7%2041.3-34.1%209.4-11.6%2017.3-24.5%2025.7-37.5-4.1.8-8.2%201-12.5.6-10.5-1-19.6-5.9-26.9-13.1-10.9%200-18.7-.4-25.1-.4zm106.1%204.8l-13.7.2c-12.9%2017-23.3%2036.5-37.9%2055%206.4%202.3%2011.4%208.4%2011.5%2013.9-.9%2010.3-10.6%2015-19%2015.1-6.1-.4-11-2-15-5.6-12.1%2010-26.8%2018.8-45.4%2025.2.2%202.4.5%204.9.6%207.3%203.1-1%206.3-1.5%209.8-1.5%2011.5.3%2023.1%207.4%2023.3%2018.1-1.3%2012.4-13.3%2018-23.3%2018.1-3.7%200-7.2-.6-10.3-1.8-.9%207.5-2.5%2015.1-5.1%2022.7l27%202.5%205.8%2029.4%2024.9-23%2012.5%2032.3c5.4-10.2%2011-20.4%2017.2-30.4-11.3-.2-23.6-6.5-23.9-16.7%201.3-12.5%2014.3-16.7%2024-16.8%207.3.4%2013.8%201.8%2019%206.2%207.8-9.8%2016.6-19.1%2026.4-27.8-1.3-3.4-3-7-5.1-10.6-3%20.8-6.4%201.2-9.9%201.2-10.2-1.1-22.7-3.5-22.9-14.5.4-6.3%204.9-10.2%209.9-12.3%201.3-.5%202.7-.9%204.1-1.2-2.7-3.5-5.1-6.5-7.8-10.1l3.7-5.5c15.5-23.2%2019.4-45.3%2019.6-69.4zm4.2%20152c-8%208.9-15%2018.3-21.6%2028.3%204.5%203.8%209.4%207.8%2014.2%2011.9%209.4%208%2019.2%2017%2021.7%2030.3l14.4%2075.9%2027.8-10.4c-3.6-28.8-5.3-48.9-12.7-81.3v-.3l-.1-.3c-1.6-10-10.3-20.4-21.8-31.6-7.1-7-15.1-14.3-21.9-22.5zM126%20373.4l-20%2050.1c-24.75%205.4-51.43%201-72.64-3.4l-7.39%2023.7c32.23%206.1%2074.93%2010.2%2097.83%205.9l18.8-31.1-8.8-44.5z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 2, name = "infantry2", hitpoints = 10, health = 25 , armyid = 2, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M159.1%2025.62l-3.5%2012.53%20134.9%2036.28%204.4-13.19zM316.4%2054.6l-8.6%2025.73c14.6%2013.43%2029.6%2014.58%2047.1%2013.07l6-29.18c-12.6-6.91-27.8-9.25-44.5-9.62zm128%2027.27l-29.6%208.09-4.7%2017.24%2023.8%2023%2052.1-11.7zm-68.5.58L373%2096.57l19.6%205.33%203.8-14.07zm-174.6%207.46c-7.3.18-14.4%203.61-20.7%209.95-7%207.24-12.4%2018.24-13.9%2031.04s1.4%2024.7%206.7%2033.3c5.4%208.4%2012.7%2013.5%2021.1%2014.4%208.4.8%2016.7-2.6%2023.8-9.9%207-7.2%2012.5-18.2%2014-31.1%201.4-12.7-1.5-24.6-6.8-33.1-5.4-8.55-12.7-13.61-21-14.47-1-.11-2.1-.15-3.2-.12zm113.3%2016.39c-4.6%2033.6-11.8%2060.1-22%2088.3l-27.5-3.6c-.4%2015-2.4%2030-7.5%2045.2%2020.6-.5%2040.2-2.8%2059.3-11.3%2011.3-37.8%2018.4-75.3%2024.3-112.9-8.9-.4-17.8-1.9-26.6-5.7zm-174.1%2076.9c-8.7%200-15.5.7-26.6%204.1-26.62%2016.2-45.72%2040.2-53%2057.9-8.4%2020.9-11.67%2047-11.26%2070.5l25.64%203.2c3.41-24%204.92-41.7%2010.83-60.8l47.29-34-2.9%2045.9%207.5-2.3c18-9.1%2030.5-20.7%2041.3-34.1%209.4-11.6%2017.3-24.5%2025.7-37.5-4.1.8-8.2%201-12.5.6-10.5-1-19.6-5.9-26.9-13.1-10.9%200-18.7-.4-25.1-.4zm106.1%204.8l-13.7.2c-12.9%2017-23.3%2036.5-37.9%2055%206.4%202.3%2011.4%208.4%2011.5%2013.9-.9%2010.3-10.6%2015-19%2015.1-6.1-.4-11-2-15-5.6-12.1%2010-26.8%2018.8-45.4%2025.2.2%202.4.5%204.9.6%207.3%203.1-1%206.3-1.5%209.8-1.5%2011.5.3%2023.1%207.4%2023.3%2018.1-1.3%2012.4-13.3%2018-23.3%2018.1-3.7%200-7.2-.6-10.3-1.8-.9%207.5-2.5%2015.1-5.1%2022.7l27%202.5%205.8%2029.4%2024.9-23%2012.5%2032.3c5.4-10.2%2011-20.4%2017.2-30.4-11.3-.2-23.6-6.5-23.9-16.7%201.3-12.5%2014.3-16.7%2024-16.8%207.3.4%2013.8%201.8%2019%206.2%207.8-9.8%2016.6-19.1%2026.4-27.8-1.3-3.4-3-7-5.1-10.6-3%20.8-6.4%201.2-9.9%201.2-10.2-1.1-22.7-3.5-22.9-14.5.4-6.3%204.9-10.2%209.9-12.3%201.3-.5%202.7-.9%204.1-1.2-2.7-3.5-5.1-6.5-7.8-10.1l3.7-5.5c15.5-23.2%2019.4-45.3%2019.6-69.4zm4.2%20152c-8%208.9-15%2018.3-21.6%2028.3%204.5%203.8%209.4%207.8%2014.2%2011.9%209.4%208%2019.2%2017%2021.7%2030.3l14.4%2075.9%2027.8-10.4c-3.6-28.8-5.3-48.9-12.7-81.3v-.3l-.1-.3c-1.6-10-10.3-20.4-21.8-31.6-7.1-7-15.1-14.3-21.9-22.5zM126%20373.4l-20%2050.1c-24.75%205.4-51.43%201-72.64-3.4l-7.39%2023.7c32.23%206.1%2074.93%2010.2%2097.83%205.9l18.8-31.1-8.8-44.5z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 3, name = "infantry3", hitpoints = 15, health = 25 , armyid = 2, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M159.1%2025.62l-3.5%2012.53%20134.9%2036.28%204.4-13.19zM316.4%2054.6l-8.6%2025.73c14.6%2013.43%2029.6%2014.58%2047.1%2013.07l6-29.18c-12.6-6.91-27.8-9.25-44.5-9.62zm128%2027.27l-29.6%208.09-4.7%2017.24%2023.8%2023%2052.1-11.7zm-68.5.58L373%2096.57l19.6%205.33%203.8-14.07zm-174.6%207.46c-7.3.18-14.4%203.61-20.7%209.95-7%207.24-12.4%2018.24-13.9%2031.04s1.4%2024.7%206.7%2033.3c5.4%208.4%2012.7%2013.5%2021.1%2014.4%208.4.8%2016.7-2.6%2023.8-9.9%207-7.2%2012.5-18.2%2014-31.1%201.4-12.7-1.5-24.6-6.8-33.1-5.4-8.55-12.7-13.61-21-14.47-1-.11-2.1-.15-3.2-.12zm113.3%2016.39c-4.6%2033.6-11.8%2060.1-22%2088.3l-27.5-3.6c-.4%2015-2.4%2030-7.5%2045.2%2020.6-.5%2040.2-2.8%2059.3-11.3%2011.3-37.8%2018.4-75.3%2024.3-112.9-8.9-.4-17.8-1.9-26.6-5.7zm-174.1%2076.9c-8.7%200-15.5.7-26.6%204.1-26.62%2016.2-45.72%2040.2-53%2057.9-8.4%2020.9-11.67%2047-11.26%2070.5l25.64%203.2c3.41-24%204.92-41.7%2010.83-60.8l47.29-34-2.9%2045.9%207.5-2.3c18-9.1%2030.5-20.7%2041.3-34.1%209.4-11.6%2017.3-24.5%2025.7-37.5-4.1.8-8.2%201-12.5.6-10.5-1-19.6-5.9-26.9-13.1-10.9%200-18.7-.4-25.1-.4zm106.1%204.8l-13.7.2c-12.9%2017-23.3%2036.5-37.9%2055%206.4%202.3%2011.4%208.4%2011.5%2013.9-.9%2010.3-10.6%2015-19%2015.1-6.1-.4-11-2-15-5.6-12.1%2010-26.8%2018.8-45.4%2025.2.2%202.4.5%204.9.6%207.3%203.1-1%206.3-1.5%209.8-1.5%2011.5.3%2023.1%207.4%2023.3%2018.1-1.3%2012.4-13.3%2018-23.3%2018.1-3.7%200-7.2-.6-10.3-1.8-.9%207.5-2.5%2015.1-5.1%2022.7l27%202.5%205.8%2029.4%2024.9-23%2012.5%2032.3c5.4-10.2%2011-20.4%2017.2-30.4-11.3-.2-23.6-6.5-23.9-16.7%201.3-12.5%2014.3-16.7%2024-16.8%207.3.4%2013.8%201.8%2019%206.2%207.8-9.8%2016.6-19.1%2026.4-27.8-1.3-3.4-3-7-5.1-10.6-3%20.8-6.4%201.2-9.9%201.2-10.2-1.1-22.7-3.5-22.9-14.5.4-6.3%204.9-10.2%209.9-12.3%201.3-.5%202.7-.9%204.1-1.2-2.7-3.5-5.1-6.5-7.8-10.1l3.7-5.5c15.5-23.2%2019.4-45.3%2019.6-69.4zm4.2%20152c-8%208.9-15%2018.3-21.6%2028.3%204.5%203.8%209.4%207.8%2014.2%2011.9%209.4%208%2019.2%2017%2021.7%2030.3l14.4%2075.9%2027.8-10.4c-3.6-28.8-5.3-48.9-12.7-81.3v-.3l-.1-.3c-1.6-10-10.3-20.4-21.8-31.6-7.1-7-15.1-14.3-21.9-22.5zM126%20373.4l-20%2050.1c-24.75%205.4-51.43%201-72.64-3.4l-7.39%2023.7c32.23%206.1%2074.93%2010.2%2097.83%205.9l18.8-31.1-8.8-44.5z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            army.Add(new ArmyUnits { id = 4, name = "infantry4", hitpoints = 20, health = 25 , armyid = 2, imgsrc = "data:image/svg+xml;charset=utf-8,%3Csvg%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%20viewBox%3D%220%200%20512%20512%22%20style%3D%22height%3A%20512px%3B%20width%3A%20512px%3B%22%3E%3Cpath%20d%3D%22M0%200h512v512H0z%22%20fill%3D%22%23000%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3Cg%20class%3D%22%22%20transform%3D%22translate(0%2C0)%22%20style%3D%22%22%3E%3Cpath%20d%3D%22M159.1%2025.62l-3.5%2012.53%20134.9%2036.28%204.4-13.19zM316.4%2054.6l-8.6%2025.73c14.6%2013.43%2029.6%2014.58%2047.1%2013.07l6-29.18c-12.6-6.91-27.8-9.25-44.5-9.62zm128%2027.27l-29.6%208.09-4.7%2017.24%2023.8%2023%2052.1-11.7zm-68.5.58L373%2096.57l19.6%205.33%203.8-14.07zm-174.6%207.46c-7.3.18-14.4%203.61-20.7%209.95-7%207.24-12.4%2018.24-13.9%2031.04s1.4%2024.7%206.7%2033.3c5.4%208.4%2012.7%2013.5%2021.1%2014.4%208.4.8%2016.7-2.6%2023.8-9.9%207-7.2%2012.5-18.2%2014-31.1%201.4-12.7-1.5-24.6-6.8-33.1-5.4-8.55-12.7-13.61-21-14.47-1-.11-2.1-.15-3.2-.12zm113.3%2016.39c-4.6%2033.6-11.8%2060.1-22%2088.3l-27.5-3.6c-.4%2015-2.4%2030-7.5%2045.2%2020.6-.5%2040.2-2.8%2059.3-11.3%2011.3-37.8%2018.4-75.3%2024.3-112.9-8.9-.4-17.8-1.9-26.6-5.7zm-174.1%2076.9c-8.7%200-15.5.7-26.6%204.1-26.62%2016.2-45.72%2040.2-53%2057.9-8.4%2020.9-11.67%2047-11.26%2070.5l25.64%203.2c3.41-24%204.92-41.7%2010.83-60.8l47.29-34-2.9%2045.9%207.5-2.3c18-9.1%2030.5-20.7%2041.3-34.1%209.4-11.6%2017.3-24.5%2025.7-37.5-4.1.8-8.2%201-12.5.6-10.5-1-19.6-5.9-26.9-13.1-10.9%200-18.7-.4-25.1-.4zm106.1%204.8l-13.7.2c-12.9%2017-23.3%2036.5-37.9%2055%206.4%202.3%2011.4%208.4%2011.5%2013.9-.9%2010.3-10.6%2015-19%2015.1-6.1-.4-11-2-15-5.6-12.1%2010-26.8%2018.8-45.4%2025.2.2%202.4.5%204.9.6%207.3%203.1-1%206.3-1.5%209.8-1.5%2011.5.3%2023.1%207.4%2023.3%2018.1-1.3%2012.4-13.3%2018-23.3%2018.1-3.7%200-7.2-.6-10.3-1.8-.9%207.5-2.5%2015.1-5.1%2022.7l27%202.5%205.8%2029.4%2024.9-23%2012.5%2032.3c5.4-10.2%2011-20.4%2017.2-30.4-11.3-.2-23.6-6.5-23.9-16.7%201.3-12.5%2014.3-16.7%2024-16.8%207.3.4%2013.8%201.8%2019%206.2%207.8-9.8%2016.6-19.1%2026.4-27.8-1.3-3.4-3-7-5.1-10.6-3%20.8-6.4%201.2-9.9%201.2-10.2-1.1-22.7-3.5-22.9-14.5.4-6.3%204.9-10.2%209.9-12.3%201.3-.5%202.7-.9%204.1-1.2-2.7-3.5-5.1-6.5-7.8-10.1l3.7-5.5c15.5-23.2%2019.4-45.3%2019.6-69.4zm4.2%20152c-8%208.9-15%2018.3-21.6%2028.3%204.5%203.8%209.4%207.8%2014.2%2011.9%209.4%208%2019.2%2017%2021.7%2030.3l14.4%2075.9%2027.8-10.4c-3.6-28.8-5.3-48.9-12.7-81.3v-.3l-.1-.3c-1.6-10-10.3-20.4-21.8-31.6-7.1-7-15.1-14.3-21.9-22.5zM126%20373.4l-20%2050.1c-24.75%205.4-51.43%201-72.64-3.4l-7.39%2023.7c32.23%206.1%2074.93%2010.2%2097.83%205.9l18.8-31.1-8.8-44.5z%22%20fill%3D%22%23fff%22%20fill-opacity%3D%221%22%3E%3C%2Fpath%3E%3C%2Fg%3E%3C%2Fsvg%3E" });
            ViewBag.Army = army;
            ViewBag.myid = armyid;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}