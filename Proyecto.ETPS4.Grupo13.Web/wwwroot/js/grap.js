var ctx = document.getElementById("grap1").getContext("2d");
var circle = document.getElementById("grap2").getContext("2d");
var myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Nomviembre", "Diciembre"],
        datasets: [{
            label: 'Datos',
            data: [0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0 ],
            backgroundColor: 'rgba(75, 192, 192, 0.2)',
            borderColor: 'rgba(75, 192, 192, 1)',
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});



var myCircleGraph = new Chart(circle, {
    type: "pie",
    data: {
        labels: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio","Agosto","Septiembre","Octubre","Nomviembre","Diciembre"],
        datasets: [
            {
                label: "Compras",
                data: [0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0],
                borderWidth: 0,
                backgroundColor: [
                    "rgba(255, 99, 132, .6)",
                    "rgba(54, 162, 235, .6)",
                    "rgba(255, 206, 86, .6)",
                    "rgba(75, 192, 192, .6)",
                    "rgba(255, 99, 132, .6)",
                    "rgba(54, 162, 235, .6)",
                    "rgba(255, 206, 86, .6)",
                    "rgba(75, 192, 192, .6)",
                    "rgba(255, 99, 132, .6)",
                    "rgba(54, 162, 235, .6)",
                    "rgba(255, 206, 86, .6)",
                    "rgba(75, 192, 192, .6)"
                ],
                borderColor: [
                    "rgba(255, 99, 132, .5)",
                    "rgba(54, 162, 235, .5)",
                    "rgba(255, 206, 86, .5)",
                    "rgba(75, 192, 192, .5)",
                    "rgba(255, 99, 132, .5)",
                    "rgba(54, 162, 235, .5)",
                    "rgba(255, 206, 86, .5)",
                    "rgba(75, 192, 192, .5)",
                    "rgba(255, 99, 132, .5)",
                    "rgba(54, 162, 235, .5)",
                    "rgba(255, 206, 86, .5)",
                    "rgba(75, 192, 192, .5)"
                ],
                lineTension: 0.1
            }
        ]
    },
    options: {
        legend: {
            display: true,
            position: "top",
            labels: {
                boxWidth: 10,
                fontColor: "#444444"
            }
        },
        plugins: {
            datalabels: {
                formatter: (value, ctx) => {

                    let sum = 0;
                    let dataArr = ctx.chart.data.datasets[0].data;
                    dataArr.map(data => {
                        sum += data;
                    });
                    let percentage = (value * 100 / sum).toFixed(2) + "%";
                    return percentage;


                },
                color: '#fff',
            }
        }
    }
});
