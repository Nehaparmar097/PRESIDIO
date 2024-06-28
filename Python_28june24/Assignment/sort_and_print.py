players = [
    {"name": "Alice", "score": 85},
    {"name": "Bob", "score": 95},
    {"name": "Charlie", "score": 75},
    {"name": "David", "score": 60},
    {"name": "Eve", "score": 90},
    {"name": "Frank", "score": 80},
    {"name": "Grace", "score": 70},
    {"name": "Hannah", "score": 65},
    {"name": "Ivy", "score": 85},
    {"name": "Jack", "score": 55},
    {"name": "Kate", "score": 92},
    {"name": "Leo", "score": 98}
]

sorted_players = sorted(players, key=lambda x: (-x['score'], x['name']))
top_10 = sorted_players[:10]

for player in top_10:
    print(f"{player['name']} - {player['score']}")

