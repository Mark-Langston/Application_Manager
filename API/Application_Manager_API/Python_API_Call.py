import requests

def fetch_applications():
    url = 'https://localhost:5001/api/applications/1'  # Update with your actual API endpoint
    try:
        response = requests.get(url, verify=False)  # Set verify=False to disable SSL verification
        if response.status_code == 200:
            applications = response.json()
            return applications
        else:
            print(f"Failed to retrieve applications. Status code: {response.status_code}")
    except requests.exceptions.RequestException as e:
        print(f"Error fetching applications: {e}")

if __name__ == "__main__":
    applications = fetch_applications()
    if applications:
        for application in applications:
            print(application)
