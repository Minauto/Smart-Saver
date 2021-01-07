import { React, useState, useEffect } from 'react';
import {Bar} from 'react-chartjs-2'

const BarChart = () => {
    return <div> 
        <Bar 
            data = {{
                
                labels: ['Test1', 'Test2'],

                datasets: [
                    {
                        label: 'Your expences',
                        data: [15, 16],
                    }
                ]

            }}
            height = {400}
            width = {600}
            options = {{
                maintainAspectRatio: false,
                scales: {
                    yAxes: [{
                        ticks: {
                            beginAtZero: true,
                        }
                    }]
                }
            }}
        />
    </div>
}

export default BarChart