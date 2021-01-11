const uri = 'api/totaldownpayment';

function addItem() {
    const existingMortgageBondTextbox = document.getElementById('existingMortgageBond');
    const purchasePriceTextbox = document.getElementById('purchasePrice');
    const cashContribution = document.getElementById('cashContribution');

    var item = {
        DownPaymentSummary: {
            existingMortgageBond: parseFloat(existingMortgageBondTextbox.value),
            purchasePrice: parseFloat(purchasePriceTextbox.value),
            cashContributionShare: parseFloat(cashContribution.value)
        }
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(data => DisplayResponse(data))
        .catch(error => console.error('Unable to parse response.', error));
}

function DisplayResponse(data) {
    const heroes = data['DownPaymentSummary'];

    const mortgageBond = document.getElementById('mortgageBondCost');
    const titleDeed = document.getElementById('titleDeedCost');
    const downPayment = document.getElementById('totalDownPaymentNeeded');

    mortgageBond.innerHTML = data.mortgageBondCost;
    titleDeed.innerHTML = data.titleDeedCost;
    downPayment.innerHTML = data.totalDownPaymentNeeded;
}