EAP-GTC-x86.msi /quiet /norestart

netsh wlan delete profile name=YZUWLAN
netsh wlan delete profile name=YZU-dot1x

netsh wlan add profile filename="YZU-dot1x.xml"
